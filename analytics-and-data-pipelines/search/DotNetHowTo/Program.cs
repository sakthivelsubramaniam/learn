
namespace AzureSearch.SDKHowTo
{
    using System;
    using System.Linq;
    using System.Threading;
    using Microsoft.Azure.Search;
    using Microsoft.Azure.Search.Models;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Spatial;

    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json");
            
            IConfigurationRoot configuration = builder.Build();

            string searchServiceName = configuration["SearchServiceName"];
            string adminApiKey = configuration["SearchServiceAdminApiKey"];
            string queryApiKey = configuration["SearchServiceQueryApiKey"];
            string indexName = configuration["SearchIndexName"];

            SearchServiceClient serviceClient = SearchServiceHelper.CreateSearchServiceClient(searchServiceName, adminApiKey );
            ISearchIndexClient indexClientForQueries = SearchServiceHelper.CreateSearchIndexClient(searchServiceName, queryApiKey, indexName);
            RunQueries(indexClientForQueries);

            Console.WriteLine("{0}", "Complete.  Press any key to end application...\n");
            Console.ReadKey();
        }


        private static void RunQueries(ISearchIndexClient indexClient)
        {
            Console.WriteLine("Run version 1 ");

            var q = new Queries(indexClient);
            //q.SearchAllField("motel");
            q.SearchAField("HotelName:\"Twin Dome Motel\"");  
            //q.SearchAField("HotelName:/.+budget.+/");  

        }
//

    }
}
