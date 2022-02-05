namespace AzDocDb
open Microsoft.Azure.Documents.Client
open System

module Say =
    let hello name =
        printfn "Hello %s" name

module  Contact =

    type Model = {
         id:string;
        _rid:string;
        _self:string;
        _etag:string;
        _attachments:string;
        _ts:int;
        }

module RouteRepository =
    let dbName = "DB1"
    let col ="contact"
   
    let getRouter =
        let connect = Connection.getConnection
        let client = new DocumentClient(Uri(connect.EndpointUrl),connect.PrimaryKey)
        let collUri = UriFactory.CreateDocumentCollectionUri(dbName, col)
        
        printf "uri is %s" collUri.OriginalString
        
        let  queryOptions = FeedOptions()
        queryOptions.MaxBufferedItemCount <- 10

        let result = client.CreateDocumentQuery<Contact.Model>(collUri,queryOptions)
                        |> Seq.head          

        printf "%s" result.id
       // printf "id is %s" result.id
