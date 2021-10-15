using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace HistoricalCrypoExchangeRates.Extensions
{
    public static class RedisCacheExtension
    {
        public static async Task SetRecordAsync<T>(this IDistributedCache cache, string recordId, T data, TimeSpan? expireTime = null)
        {
            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expireTime ?? TimeSpan.FromSeconds(60)
            };

            await cache.SetStringAsync(recordId, JsonSerializer.Serialize(data), options);
        }

        public static async Task<T> GetRecordAsync<T>(this IDistributedCache cache, string recordId)
        {
            var serializedData = await cache.GetStringAsync(recordId);
            if (serializedData is null)
            {
                return default(T);
            }
            return JsonSerializer.Deserialize<T>(serializedData);
        }
    }
}
