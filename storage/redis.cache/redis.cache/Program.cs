using System;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace redis.cache
{

    public class Program
    {

        IDatabase cache =  null; 
        public  void Connect()
        {
            // Connect to the Azure Redis cache
            ConfigurationOptions config = new ConfigurationOptions();

            config.EndPoints.Add("<your DNS name>.redis.cache.windows.net");
            config.Password = "<Redis cache key from management portal>";
            ConnectionMultiplexer redisHostConnection = ConnectionMultiplexer.Connect(config);
            cache = redisHostConnection.GetDatabase();

        }

        private async Task<string> RetrieveItem(string itemKey)
        {
            // Attempt to retrieve the item from the Redis cache
            string itemValue = await cache.StringGetAsync(itemKey);

            // If the value returned is null, the item was not found in the cache
            // So retrieve the item from the data source and add it to the cache
            if (itemValue == null)
            {
                itemValue = await GetItemFromDataSourceAsync(itemKey);
                await cache.StringSetAsync(itemKey, itemValue);
            }

            // Return the item
            return itemValue;
        }

        private async Task<string> GetItemFromDataSourceAsync(string key)
        {
            return "";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
