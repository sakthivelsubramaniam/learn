using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using System.IO;

namespace AzureStorage
{   
    public class BlobStorageHelper
    {
        CloudBlobContainer _cloudBlobContainer;

        string _connectionString;
        string _containerName;

        public BlobStorageHelper(string connectionString, string containerName)
        {
            this._connectionString = connectionString;
            this._containerName = containerName;
        }

        public async  Task<CloudBlobContainer> InitializeAsync()
        {
            var storageAccount = CloudStorageAccount.Parse(_connectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
            _cloudBlobContainer = blobClient.GetContainerReference(_containerName);
             await _cloudBlobContainer.CreateIfNotExistsAsync();
            return _cloudBlobContainer;
        }
        public async Task Upload(string blobName, Stream fileStream)
        {
           var blobRef = _cloudBlobContainer.GetBlockBlobReference(blobName);
            await blobRef.UploadFromStreamAsync(fileStream);
        }

    }
}
