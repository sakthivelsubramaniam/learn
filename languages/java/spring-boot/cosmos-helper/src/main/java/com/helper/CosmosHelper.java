package com.helper;

import java.io.IOException;

import com.microsoft.azure.documentdb.ConnectionPolicy;
import com.microsoft.azure.documentdb.ConsistencyLevel;
import com.microsoft.azure.documentdb.DataType;
import com.microsoft.azure.documentdb.Database;
import com.microsoft.azure.documentdb.Document;
import com.microsoft.azure.documentdb.DocumentClient;
import com.microsoft.azure.documentdb.DocumentClientException;
import com.microsoft.azure.documentdb.DocumentCollection;
import com.microsoft.azure.documentdb.FeedOptions;
import com.microsoft.azure.documentdb.FeedResponse;
import com.microsoft.azure.documentdb.Index;
import com.microsoft.azure.documentdb.IndexingPolicy;
import com.microsoft.azure.documentdb.RangeIndex;
import com.microsoft.azure.documentdb.RequestOptions;

import com.azure.cosmos.examples.common.Family;

public class CosmosHelper {

    private DocumentClient client;
    
    private final String databaseName = "SampleDB";
    private final String containerName = "FamilyContainer";
   // private final String documentId =    UUID.randomUUID().toString();
    private final String documentLastName = "Witherspoon";
    private Database database;
    private DocumentCollection container;

    public void Exeute()  throws DocumentClientException, IOException  {

        this.client = new DocumentClient("https://learn-cosmosdb.documents.azure.com:443/",
                "g2FDFq7YCDHu6dKwU3mv5v98mBNK6fXBdAClIis8NjwgO7jvrW2QR2KrdlbgtsqsersobiLl5YHCXIrd36fbKQ==", 
                new ConnectionPolicy(),
                ConsistencyLevel.Session);
        
                this.createDatabaseIfNotExists("SampleDB");
                this.createDocumentCollectionIfNotExists("SampleDB", "FamilyCollection");
        

    }

    private void createDatabaseIfNotExists(String databaseName) throws DocumentClientException, IOException {
        String databaseLink = String.format("/dbs/%s", databaseName);

        // Check to verify a database with the id=FamilyDB does not exist
        try {
            this.client.readDatabase(databaseLink, null);
            this.writeToConsoleAndPromptToContinue(String.format("Found %s", databaseName));
        } catch (DocumentClientException de) {
            // If the database does not exist, create a new database
            if (de.getStatusCode() == 404) {
                Database database = new Database();
                database.setId(databaseName);
                
                this.client.createDatabase(database, null);
                this.writeToConsoleAndPromptToContinue(String.format("Created %s", databaseName));
            } else {
                throw de;
            }
        }
    }

    private void createDocumentCollectionIfNotExists(String databaseName, String collectionName) throws IOException,
            DocumentClientException {
        String databaseLink = String.format("/dbs/%s", databaseName);
        String collectionLink = String.format("/dbs/%s/colls/%s", databaseName, collectionName);

        try {
            this.client.readCollection(collectionLink, null);
            writeToConsoleAndPromptToContinue(String.format("Found %s", collectionName));
        } catch (DocumentClientException de) {
            // If the document collection does not exist, create a new
            // collection
            if (de.getStatusCode() == 404) {
                DocumentCollection collectionInfo = new DocumentCollection();
                collectionInfo.setId(collectionName);

                // Optionally, you can configure the indexing policy of a
                // collection. Here we configure collections for maximum query
                // flexibility including string range queries.
                RangeIndex index = new RangeIndex(DataType.String);
                index.setPrecision(-1);

                collectionInfo.setIndexingPolicy(new IndexingPolicy(new Index[] { index }));

                // DocumentDB collections can be reserved with throughput
                // specified in request units/second. 1 RU is a normalized
                // request equivalent to the read of a 1KB document. Here we
                // create a collection with 400 RU/s.
                RequestOptions requestOptions = new RequestOptions();
                requestOptions.setOfferThroughput(400);

                this.client.createCollection(databaseLink, collectionInfo, requestOptions);

                this.writeToConsoleAndPromptToContinue(String.format("Created %s", collectionName));
            } else {
                throw de;
            }
        }

    }

    private void createFamilyDocumentIfNotExists(String databaseName, String collectionName, Family family)
            throws DocumentClientException, IOException {
        try {
            String documentLink = String.format("/dbs/%s/colls/%s/docs/%s", databaseName, collectionName, family.getId());
            this.client.readDocument(documentLink, new RequestOptions());
        } catch (DocumentClientException de) {
            if (de.getStatusCode() == 404) {
                String collectionLink = String.format("/dbs/%s/colls/%s", databaseName, collectionName);
                this.client.createDocument(collectionLink, family, new RequestOptions(), true);
                this.writeToConsoleAndPromptToContinue(String.format("Created Family %s", family.getId()));
            } else {
                throw de;
            }
        }
    }


    private void executeSimpleQuery(String databaseName, String collectionName) {
        // Set some common query options
        FeedOptions queryOptions = new FeedOptions();
        queryOptions.setPageSize(-1);
        queryOptions.setEnableCrossPartitionQuery(true);

        String collectionLink = String.format("/dbs/%s/colls/%s", databaseName, collectionName);
        FeedResponse<Document> queryResults = this.client.queryDocuments(collectionLink,
                "SELECT * FROM Family WHERE Family.lastName = 'Andersen'", queryOptions);

        System.out.println("Running SQL query...");
        for (Document family : queryResults.getQueryIterable()) {
            System.out.println(String.format("\tRead %s", family));
        }
    }

    private void writeToConsoleAndPromptToContinue(String text) throws IOException {
        System.out.println(text);
        System.out.println("Press any key to continue ...");
        System.in.read();
    }



}