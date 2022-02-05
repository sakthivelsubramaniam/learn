using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage;

namespace AzureStorage
{   
    public class TableStorageHelper
    {
        string ConnectionString;
        public TableStorageHelper(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private CloudTable GetTableRef(string tableName)
        {
            var storageAccount = CloudStorageAccount.Parse(this.ConnectionString);
            var tableClient = storageAccount.CreateCloudTableClient();
            return tableClient.GetTableReference(tableName);
        }

        public async Task<bool> Create(string tableName)
        {
            var tableRef = this.GetTableRef(tableName);
            return await tableRef.CreateIfNotExistsAsync();
        }

        public async Task<TableResult> Update<TEntity>(string tableName, TEntity entity) where TEntity:TableEntity
        {
            var tableRef = this.GetTableRef(tableName);
            var insertOrUpdateOperation = TableOperation.InsertOrMerge(entity);
            return await tableRef.ExecuteAsync(insertOrUpdateOperation);
        }


        public async Task<TableResult> Delete<TEntity>(string tableName, TEntity entity) where TEntity : TableEntity
        {
            var tableRef = this.GetTableRef(tableName);
            var deleteOperation = TableOperation.Delete(entity);
            return await tableRef.ExecuteAsync(deleteOperation);
        }

        public async Task<TEntity> GetRetrieveAsync<TEntity>(string tableName, string partitionKey,string rowKey) where TEntity : TableEntity
        {
            var tableRef = this.GetTableRef(tableName);
            var operations = TableOperation.Retrieve(partitionKey, rowKey);
            var results = await tableRef.ExecuteAsync(operations);

            return results.Result as TEntity;

        }

        //public IEnumerable<TEntity> GetRetrieve<TEntity>(string tableName, TableQuery<TEntity> query ) where TEntity : TableEntity,new()
        //{
        //    var tableRef = this.GetTableRef(tableName);
        //    return tableRef.ExecuteQuery(query);

        //}

        //public IEnumerable<TEntity> Query<TEntity>(string tableName, TableQuery<TEntity> query) 
        //    where TEntity : TableEntity, new()
        //{

        //    // Initialize the continuation token to null to start from the beginning of the table.
        //    TableContinuationToken continuationToken = null;
        //    var tableRef = this.GetTableRef(tableName);
        //    do
        //    {
        //        var configuredAwaiter = tableRef.ExecuteQuerySegmentedAsync(query, continuationToken)
        //                                 .ConfigureAwait(false);

        //        var tableQueryResult = configuredAwaiter.GetAwaiter().GetResult();
                

        //        // Assign the new continuation token to tell the service where to
        //        // continue on the next iteration (or null if it has reached the end).
        //        continuationToken = tableQueryResult.ContinuationToken;

        //        foreach (var entity in tableQueryResult.Results)
        //        {
        //            yield return entity;
        //        }

        //        //SynchronizationContext.Current
        //       // TaskScheduler.Default

        //        // Loop until a null continuation token is received, indicating the end of the table.
        //    } while (continuationToken != null);

        //}

        //public async TableResult Delete1<TEntity>(string tableName, TEntity entity) where TEntity : TableEntity
        //{
        //    var tableRef = this.GetTableRef(tableName);
        //    var deleteOperation = TableOperation.Delete(entity);
        //    return await tableRef.ExecuteAsync(deleteOperation);
        //}
    }
}
