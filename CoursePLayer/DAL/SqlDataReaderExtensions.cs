using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace HRS.CoursePlayer
{
    public static class SqlDataReaderExtensions
    {
        private static Dictionary<Type, object> Mappings;
        static SqlDataReaderExtensions()
        {
            Mappings = new Dictionary<Type, object>();

            var dataReaderType = typeof(SqlDataReader);

            var methods = dataReaderType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Where(m => m.Name.StartsWith("Get")).ToArray();
                    
            foreach(var method in methods)
            {
                var returnType = method.ReturnType.Name;

                if (!method.Name.Equals(string.Format("Get{0}", returnType)))
                {
                    continue;
                }

                if (Mappings.ContainsKey(method.ReturnType))
                {
                    continue;
                }
                
                if (method.GetParameters().Length != 1)
                {
                    continue;
                }

                var reader = Expression.Parameter(dataReaderType, "r");
                var ordinal = Expression.Parameter(typeof(int), "o");

                var call = Expression.Call(reader, method, ordinal);
                var funcType = Expression.GetFuncType(typeof(SqlDataReader), typeof(int), method.ReturnType);

                Mappings.Add(method.ReturnType, Expression.Lambda(funcType, call, reader, ordinal).Compile());
           
            }
        }
        
        public static void SetValueForColumn<T>(this SqlDataReader reader, string columnName, Action<T> setter)
        {
            int index = reader.GetOrdinal(columnName);
            Type type = typeof(T);
            if (index > -1 && !reader.IsDBNull(index))
            {
                Func<SqlDataReader, int, T> getter = null;
                if (Mappings.ContainsKey(type))
                {
                    getter = (Func<SqlDataReader, int, T>) Mappings[type];
                }
                else
                {
                    getter = (r, i) => ValueConverter<T>.Instance.ConvertValue(r.GetValue(i));
                }

                T item = getter(reader, index);
                setter(item);
            }
        }
        // Following taken from MSDN: http://social.msdn.microsoft.com/Forums/is/csharpgeneral/thread/a0dd7a9b-4d0c-4035-ac23-657f9ba9ddb3
        internal class ValueConverter<T>
        {
            internal static readonly ValueConverter<T> Instance = Initialize();
            private static ValueConverter<T> Initialize()
            {
                Type type = typeof(T);
                Type underlyingType = Nullable.GetUnderlyingType(type);

                if (underlyingType != null)
                {
                    // if T is nullable, use reflection to create an instance of NullableValueConverter
                    Type converterType = typeof(NullableValueConverter<>);
                    converterType = converterType.MakeGenericType(underlyingType);
                    return (ValueConverter<T>)Activator.CreateInstance(converterType);
                }
                return new ValueConverter<T>();
            }
            internal virtual T ConvertValue(object value)
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }
        internal class NullableValueConverter<T> : ValueConverter<T?> where T : struct
        {
            internal override T? ConvertValue(object value)
            {
                if (value == null)
                    return null;
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }
    }
}