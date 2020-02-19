using System;
using System.Collections.Generic;
using System.Data;

using System.Reflection;
using System.Collections;

namespace HRS.CoursePlayer
{
    public class Converter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public DataSet ConvertToDataSet<T>(IList list)
        {
            DataSet dataSet = new DataSet();
            CreateDataSet(dataSet, typeof(T), null, null);
            ConvertInfo cInfo = new ConvertInfo();
            FillDataSet(typeof(T), list, dataSet, cInfo);
            return dataSet;
        }

        /// Create the structure for all the tables in the data set        
        /// Data set in which tables will be created
        /// Type of which dataset has to be created
        /// Whether current type is a child table  
        private void CreateDataSet(DataSet dataSet, Type type, string parentTable, string pPropertyName)
        {
            string tblListRange = "ListRange";
            if (string.IsNullOrEmpty(pPropertyName))
            {
                pPropertyName = type.Name;
            }
            DataTable dataTable;
            if (dataSet.Tables.Contains(pPropertyName))
            {
                dataTable = dataSet.Tables[pPropertyName];
                if (!string.IsNullOrEmpty(parentTable) && !dataTable.Columns.Contains(parentTable + "_ID"))
                {
                    if (dataTable.Columns.Contains(parentTable + "_ID"))
                        return;
                }
            }
            else
            {
                dataSet.Tables.Add(pPropertyName);
                if (!dataSet.Tables.Contains(tblListRange))
                {
                    dataSet.Tables.Add(tblListRange);
                }
                dataTable = dataSet.Tables[pPropertyName];
            }
            //Create the ID columns for having relation in the tables 
            if (!dataTable.Columns.Contains(pPropertyName + "_ID"))
            {
                dataTable.Columns.Add(new DataColumn(pPropertyName + "_ID", typeof(int)));
            }
            if (!string.IsNullOrEmpty(parentTable) && !dataTable.Columns.Contains(parentTable + "_ID"))
            {
                dataTable.Columns.Add(new DataColumn(parentTable + "_ID", typeof(int)));
            }
            // Create the structure for the data tables to be
            // added in the the data set            
            foreach (PropertyInfo pInfo in type.GetProperties())
            {
                if (pInfo.PropertyType.IsGenericType &&
                (pInfo.PropertyType.GetGenericTypeDefinition() == typeof(List<>)
                || pInfo.PropertyType.GetGenericTypeDefinition() == typeof(IList<>)))
                {
                    // If associate lists are there make then another table
                    CreateDataSet(dataSet, pInfo.PropertyType.GetGenericArguments()[0], pPropertyName, pInfo.Name);
                }
                else if (pInfo.PropertyType.BaseType == typeof(BaseEntity)
                || pInfo.PropertyType == typeof(EntityRange))
                {
                    CreateDataSet(dataSet, pInfo.PropertyType, pPropertyName, pInfo.Name);
                }
                else
                {
                    if (!dataTable.Columns.Contains(pInfo.Name))
                    {
                        Type propType = pInfo.PropertyType;
                        if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            propType = Nullable.GetUnderlyingType(propType);
                            dataTable.Columns.Add(new DataColumn(pInfo.Name, propType));
                            dataTable.Columns[pInfo.Name].AllowDBNull = true;
                        }
                        else if (propType.IsEnum)
                        {
                            dataTable.Columns.Add(new DataColumn(pInfo.Name, typeof(String)));
                            dataTable.Columns[pInfo.Name].AllowDBNull = true;
                        }
                        else
                        {

                            //if (propType == typeof(System.DateTime))
                            //    propType = typeof(System.String);
                            dataTable.Columns.Add(new DataColumn(pInfo.Name, propType));
                        }
                    }
                }
            }
        }

        /// Fill all the tables of data set with data in the respective list 
        /// Type of which datatable is to be filled
        /// List of data
        /// Data Set in which data tables will be filled with data
        /// ID of parent record. If -1 one then no parent        
        private void FillDataSet(Type type, IList list, DataSet dataSet, ConvertInfo pInfo)
        {
            PropertyInfo[] propertyInfos = type.GetProperties();
            if (string.IsNullOrEmpty(pInfo.TableName))
            {
                pInfo.TableName = type.Name;
            }
            DataTable dataTable = dataSet.Tables[pInfo.TableName];
            int id = dataTable.Rows.Count + 1;
            foreach (object item in list)
            {
                if (item != null)
                {
                    DataRow row = dataTable.NewRow();
                    // Set new id and related parent id
                    row[pInfo.TableName + "_ID"] = id;
                    if (pInfo.ParentID != -1)
                        row[pInfo.ParentTableName + "_ID"] = pInfo.ParentID;
                    // Load all the data from the properties of the type
                    // and save them into the datatable                

                    foreach (PropertyInfo info in propertyInfos)
                    {
                        if (info.PropertyType.IsGenericType &&
                        (info.PropertyType.GetGenericTypeDefinition() == typeof(List<>)
                        || info.PropertyType.GetGenericTypeDefinition() == typeof(IList<>)))
                        {
                            if (item != null)
                            {
                                IList subList = (IList)info.GetValue(item, null);
                                if (subList != null && subList.Count > 0)
                                {
                                    ConvertInfo cfInfo = new ConvertInfo();
                                    cfInfo.ParentID = id;
                                    cfInfo.TableName = info.Name;
                                    cfInfo.ParentTableName = pInfo.TableName;
                                    FillDataSet(subList[0].GetType(), subList, dataSet, cfInfo);
                                }
                            }
                        }
                        else if (info.PropertyType.BaseType == typeof(BaseEntity)
                                || info.PropertyType == typeof(EntityRange))
                        {
                            if (item != null)
                            {
                                ConvertInfo cfInfo = new ConvertInfo();
                                cfInfo.ParentID = id;
                                cfInfo.TableName = info.Name;
                                cfInfo.ParentTableName = pInfo.TableName;
                                FillDataSet(info.PropertyType, info.GetValue(item, null), dataSet, cfInfo);
                            }
                        }
                        else if (info.PropertyType.IsEnum)
                        {
                            if (item != null)
                            {
                                row[info.Name] = info.GetValue(item, null).ToString();
                            }
                        }
                        else
                        {
                            if (item != null)
                            {
                                if (!string.IsNullOrEmpty(Convert.ToString(info.GetValue(item, null))))
                                    row[info.Name] = info.GetValue(item, null);
                                else
                                    row[info.Name] = DBNull.Value;
                            }
                            else
                                row[info.Name] = DBNull.Value;
                        }
                    }
                    dataTable.Rows.Add(row);
                    id++;
                }
            }
        }

        /// <summary>
        /// FillDataSet Overload method
        /// </summary>
        /// <param name="type"></param>
        /// <param name="item"></param>
        /// <param name="dataSet"></param>
        /// <param name="parentID"></param>
        /// <param name="pTableName"></param>
        /// <param name="pParentTableName"></param>
        private void FillDataSet(Type type, object item, DataSet dataSet, ConvertInfo pInfo)
        {
            PropertyInfo[] propertyInfos = type.GetProperties();           
            if (item != null)
            {
                if (string.IsNullOrEmpty(pInfo.TableName))
                {
                    pInfo.TableName = type.Name;
                }
                DataTable dataTable = dataSet.Tables[pInfo.TableName];
                int id = dataTable.Rows.Count + 1;
                DataRow row = dataTable.NewRow();
                // Set new id and related parent id
                row[pInfo.TableName + "_ID"] = id;
                if (pInfo.ParentID != -1)
                    row[pInfo.ParentTableName + "_ID"] = pInfo.ParentID;
                // Load all the data from the properties of the type
                // and save them into the datatable
                foreach (PropertyInfo info in propertyInfos)
                {
                    if (info.PropertyType.IsGenericType &&
                    (info.PropertyType.GetGenericTypeDefinition() == typeof(List<>)
                    || info.PropertyType.GetGenericTypeDefinition() == typeof(IList<>)))
                    {
                        if (item != null)
                        {
                            IList subList = (IList)info.GetValue(item, null);
                            if (subList != null && subList.Count > 0)
                            {
                                ConvertInfo cfInfo = new ConvertInfo();
                                cfInfo.ParentID = id;
                                cfInfo.ParentTableName = pInfo.TableName;
                                cfInfo.TableName = info.Name;                                
                                FillDataSet(subList[0].GetType(), subList, dataSet, cfInfo);
                            }
                        }
                    }
                    else if (info.PropertyType.BaseType == typeof(BaseEntity)
                            || info.PropertyType == typeof(EntityRange))
                    {
                        if (item != null)
                        {
                            ConvertInfo cfInfo = new ConvertInfo();
                            cfInfo.ParentID = id;
                            cfInfo.ParentTableName = pInfo.TableName;
                            cfInfo.TableName = info.Name;
                            FillDataSet(info.PropertyType, info.GetValue(item, null), dataSet, cfInfo);
                        }
                    }
                    else if (info.PropertyType.IsEnum)
                    {
                        if (item != null)
                        {
                            row[info.Name] = info.GetValue(item, null).ToString();
                        }
                    }
                    else
                    {
                        if (item != null)
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(info.GetValue(item, null))))
                                row[info.Name] = info.GetValue(item, null);
                            else
                                row[info.Name] = DBNull.Value;
                        }
                        else
                            row[info.Name] = DBNull.Value;
                    }
                }
                dataTable.Rows.Add(row);
                id++;
            }
        }

        //For Parameters
        public class ConvertInfo
        {
            int parentID = -1; string pTableName = null; string pParentTableName = null;
            public int ParentID
            {
                get { return parentID; }
                set { parentID = value; }
            }
            public string TableName
            {
                get { return pTableName; }
                set { pTableName = value; }
            }
            public string ParentTableName
            {
                get { return pParentTableName; }
                set { pParentTableName = value; }
            }
        }
    }
}