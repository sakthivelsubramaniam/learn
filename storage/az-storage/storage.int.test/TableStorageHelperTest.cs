using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureStorage.Test
{
    [TestClass]
    public class TableStorageHelperTest
    {
        [TestMethod]
        public void Create()
        {
            var tableStorageHelper = new TableStorageHelper(Config.GetStorageConnectionString());
            var resultTask = tableStorageHelper.Create("Person");
                resultTask.Wait();
        }





    }

   
}
