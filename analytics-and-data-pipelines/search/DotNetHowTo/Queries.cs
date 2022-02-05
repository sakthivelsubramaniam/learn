namespace AzureSearch.SDKHowTo
{
    using System;
    using System.Linq;
    using System.Threading;
    using Microsoft.Azure.Search;
    using Microsoft.Azure.Search.Models;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Spatial;

    public class Queries
    {
        ISearchIndexClient indexClient;
        public Queries(ISearchIndexClient indexClient)
        {
            this.indexClient = indexClient;
        }

        public  void SearchAllField(string searchTerm)
        {
            SearchParameters parameters;
            DocumentSearchResult<Hotel> results;

            Console.WriteLine("Search the entire index for the term 'motel' and return only the HotelName field:\n");

            parameters =
                new SearchParameters()
                {
                    Select = new[] { "HotelName" }
                };

            results = indexClient.Documents.Search<Hotel>(searchTerm, parameters);

            WriteDocuments(results);

        }
 
        public  void FilterAndSearch()
        {
            SearchParameters parameters;
            DocumentSearchResult<Hotel> results;

            Console.Write("Apply a filter to the index to find hotels with a room cheaper than $100 per night, ");
            Console.WriteLine("and return the hotelId and description:\n");

            parameters =
                new SearchParameters()
                {
                    Filter = "Rooms/any(r: r/BaseRate lt 100)",
                    Select = new[] { "HotelId", "Description" }
                };

            results = indexClient.Documents.Search<Hotel>("*", parameters);

            WriteDocuments(results);
            
        }
        public  void Queries3()
        {
            SearchParameters parameters;
            DocumentSearchResult<Hotel> results;

            Console.Write("Search the entire index, order by a specific field (lastRenovationDate) ");
            Console.Write("in descending order, take the top two results, and show only hotelName and ");
            Console.WriteLine("lastRenovationDate:\n");

            parameters =
                new SearchParameters()
                {
                    OrderBy = new[] { "LastRenovationDate desc" },
                    Select = new[] { "HotelName", "LastRenovationDate" },
                    Top = 2
                };

            results = indexClient.Documents.Search<Hotel>("*", parameters);

            WriteDocuments(results);
            
        }
        public void SearchAField(string seachTerm)
        {
            SearchParameters parameters;
            DocumentSearchResult<Hotel> results;

            Console.WriteLine($"Search the hotel names for the term {seachTerm}:\n");

            parameters = new SearchParameters()
            {
                //SearchFields = new[] { "HotelName" },
                QueryType = QueryType.Full,
                SearchMode = SearchMode.Any,
      
            };
            results = indexClient.Documents.Search<Hotel>(seachTerm, parameters);

            WriteDocuments(results);
            
        }
        public  void Queries5()
        {
                SearchParameters parameters;
                DocumentSearchResult<Hotel> results;


        }
        private  void WriteDocuments(DocumentSearchResult<Hotel> searchResults)
        {
            foreach (SearchResult<Hotel> result in searchResults.Results)
            {
                Console.WriteLine(result.Document);
            }

            Console.WriteLine();
        }


    }
    
}