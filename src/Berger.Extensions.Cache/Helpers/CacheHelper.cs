using Microsoft.Extensions.Caching.Memory;

namespace Berger.Extensions.Cache
{
    public static class CacheHelper
    {
        public static T Get<T>(this IMemoryCache cache, object key, bool expiration)
        {
           return cache.Get<T>(key);
        }
        public static T Set<T>(this IMemoryCache cache, object key, T value, bool expiration)
        {
            return cache.Set(key, value);
        }
    }
}