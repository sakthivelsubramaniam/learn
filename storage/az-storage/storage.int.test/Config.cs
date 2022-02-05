using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorage.Test
{
    public static class Config
    {
        public static string GetStorageConnectionString()
        {
            return "UseDevelopmentStorage=true";
        }
    }
}
