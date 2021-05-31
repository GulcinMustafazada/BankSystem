using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        protected ObjectCache Cache => MemoryCache.Default;
        public void Add(string key, object data, int cacheTime)
        {
            if (data is null)
            {
                return;
            }
            var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime) };
            Cache.Add(new CacheItem(key, data), policy);
        }

        public void Clear()
        {
            foreach(var c in Cache)
            {
                Remove(c.Key);
            }
        }

        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public bool IsAdd(string key)
        {
            return Cache.Contains(key);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var keysToRemove = Cache.Where(k => regex.IsMatch(k.Key)).Select(k => k.Key).ToList();
            foreach (var c in Cache)
            {
                Remove(c.Key);
            }
        }
    }
}
