using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRS.CoursePlayer
{
    public interface ICacheProvider
    {
        bool ContainsKey(string key);
        T Get<T>(string key);
        T Get<T>(string key, Func<T> retriever);
        void Add<T>(string key, T obj);
        void Add<T>(string key, T obj, int duration);
        void Add<T>(string key, T obj, string fileDependencyPath);
        void Remove(string key);
        void Remove(Predicate<string> match);
    }
}
