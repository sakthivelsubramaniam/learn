

namespace AzureSearch.SDKHowTo
{
    using System;
    using System.Linq;
    using System.Threading;
    using Microsoft.Azure.Search;
    using Microsoft.Azure.Search.Models;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Spatial;

    public class SearchServiceHelper
    {
        public static void ReCreateIndex(string indexName, SearchServiceClient serviceClient)
        {
            Console.WriteLine("{0}", "Deleting index...\n");
            DeleteIndexIfExists(indexName, serviceClient);

            Console.WriteLine("{0}", "Creating index...\n");
            CreateIndex(indexName, serviceClient);

            ISearchIndexClient indexClient = serviceClient.Indexes.GetClient(indexName);
            Console.WriteLine("{0}", "Uploading documents...\n");
            SearchIndexHelper.UploadDocuments(indexClient);

        }        

        public static SearchServiceClient CreateSearchServiceClient(string searchServiceName, string adminApiKey )
        {

            SearchServiceClient serviceClient = new SearchServiceClient(searchServiceName, new SearchCredentials(adminApiKey));
            return serviceClient;
        }

        public  static SearchIndexClient CreateSearchIndexClient(string searchServiceName, string queryApiKey, string indexName)
        {

            SearchIndexClient indexClient = new SearchIndexClient(searchServiceName, indexName, new SearchCredentials(queryApiKey));
            return indexClient;
        }

        private static void DeleteIndexIfExists(string indexName, SearchServiceClient serviceClient)
        {
            if (serviceClient.Indexes.Exists(indexName))
            {
                serviceClient.Indexes.Delete(indexName);
            }
        }

        private static void CreateIndex(string indexName, SearchServiceClient serviceClient)
        {
            var definition = new Index()
            {
                Name = indexName,
                Fields = FieldBuilder.BuildForType<Hotel>()
            };

            serviceClient.Indexes.Create(definition);
        }

        
    }

}