using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;

namespace docdb
{
   
    public class Contactmodel
    {
        public string id { get; set; }
        public string name { get; set;}
        public string city {get;set;}
        public string _rid { get; set; }
        public string _self { get; set; }
        public string _etag { get; set; }
        public string _attachments { get; set; }
        public int _ts { get; set; }
    }
    
    public class Docdbhelper
    {
        string EndpointUrl="https://localhost:8081/";
        string PrimaryKey="C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        public void GetContact()
        {
            var  queryOptions = new FeedOptions()
            {
                MaxBufferedItemCount = 10
            };
            var collUri = UriFactory.CreateDocumentCollectionUri("DB1", "contact");
            var client = new DocumentClient(new Uri(EndpointUrl),PrimaryKey);
            var result = client.CreateDocumentQuery<Contactmodel>(collUri,queryOptions)
                            .ToList();

             var item =  result.Where( f => f.id == "01")
                                    .FirstOrDefault();

            System.Console.WriteLine(item.id);
        }

        public async Task Created()
        {
            var collUri = UriFactory.CreateDocumentCollectionUri("DB1", "contact");
            var client = new DocumentClient(new Uri(EndpointUrl),PrimaryKey);
            await client.OpenAsync();                
            var contact2 = new { id = "42", name = "Max", city="Aberdeen" };
            var attachmentStream = File.OpenRead("D:/Code/ref/Storage/docdb/Resource/filetoupload.cs"); // this is the document stream you are attaching
            var resourceResponse = await client.CreateDocumentAsync(collUri, contact2);

            await client.CreateAttachmentAsync(resourceResponse.Resource.SelfLink, attachmentStream, new MediaOptions()
            {
                ContentType = "application/test", // your application type
                Slug = "78", // this is actually attachment ID
            });
        }

        public async Task ListAttachement()
        {
             var  queryOptions = new FeedOptions()
            {
                MaxBufferedItemCount = 10
            };
            var collUri = UriFactory.CreateDocumentCollectionUri("DB1", "contact");
            var client = new DocumentClient(new Uri(EndpointUrl),PrimaryKey);
            //client.ReadAttachmentAsync
        }

    }
    
}