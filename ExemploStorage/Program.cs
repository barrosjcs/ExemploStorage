using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Table;

namespace ExemploStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inclusão da Access Key string do Azure
            CloudStorageAccount account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=storage13net;AccountKey=AhDlxuw3BZ3XhhFvgJUNmvVDBoiUZFXwrZoty/hLCiXdFzR2B/wXVnzlbS/dnRIt7oC/jn8mcvNYoaDluvercg==;EndpointSuffix=core.windows.net");

            #region blob
            //var blobClient = account.CreateCloudBlobClient();

            //var container = blobClient.GetContainerReference("rm331334");
            //container.CreateIfNotExistsAsync().Wait();

            //var blob = container.GetBlockBlobReference("jsbarros2.txt");
            //blob.UploadTextAsync("Vai Corinthians").Wait();
            //var sas = blob.GetSharedAccessSignature(new SharedAccessBlobPolicy
            //{
            //    Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write,
            //    SharedAccessExpiryTime = DateTime.Now.AddMinutes(10)
            //});

            //Console.WriteLine($"{blob.Uri}{sas}");
            #endregion

            var client = account.CreateCloudTableClient();
            var table = client.GetTableReference("rm331334");
            table.CreateIfNotExistsAsync().Wait();
            var entity = new Aluno("331334", "SP")
            {
                Email = "331334@fiap.com",
                Nome = "Jefferson"
            };

            table.ExecuteAsync(TableOperation.Insert(entity));

            Console.Read();
            Console.WriteLine("Hello World!");
        }
    }
}
