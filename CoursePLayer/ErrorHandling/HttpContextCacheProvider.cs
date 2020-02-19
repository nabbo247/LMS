using System;
using System.Collections;
using System.Web.Caching;
using System.Linq;

namespace HRS.CoursePlayer
{
    public class HttpContextCacheProvider : ICacheProvider
    {
        private readonly Cache m_Cache;

        public HttpContextCacheProvider(Cache cache)
        {
            m_Cache = cache;
        }

        public bool ContainsKey(string key)
        {
            return m_Cache[key] != null;
        }

        public T Get<T>(string key)
        {
            if (!ContainsKey(key))
            {
                return default(T);
            }

            try
            {
                return (T)m_Cache[key];
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }

        public T Get<T>(string key, Func<T> retriever)
        {
            T item = Get<T>(key);

            bool isPresent = false;
            
            if (!typeof(T).IsValueType)
            {
                isPresent = item != null;
            }
            else
            {
                isPresent = !item.Equals(default(T));
            }

            if (!isPresent)
            {
                item = retriever();
            }

            return item;
        }

        public void Add<T>(string key, T obj)
        {
            Add(key, obj, 60);
        }

        public void Add<T>(string key, T obj, int duration)
        {
            m_Cache.Add(key, obj, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(duration), CacheItemPriority.BelowNormal, null);
        }

        public void Remove(string key)
        {
            if (ContainsKey(key))
            {
                m_Cache.Remove(key);
            }
        }

        public void Remove(Predicate<string> match)
        {
            var items = m_Cache.OfType<DictionaryEntry>().ToArray().Where(v => match(v.Key.ToString()));

            foreach (var item in items)
            {
                m_Cache.Remove(item.Key.ToString());
            }
        }

        public void Add<T>(string key, T obj, string fileDependencyPath)
        {
            m_Cache.Add(key, obj, new CacheDependency(fileDependencyPath),
                                              Cache.NoAbsoluteExpiration, new TimeSpan(1, 0, 0), CacheItemPriority.Normal, null);
        }
    }
}
