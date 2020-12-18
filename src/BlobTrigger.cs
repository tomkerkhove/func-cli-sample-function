using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureCliSandbox
{
    public static class BlobTrigger
    {
        [FunctionName("BlobTrigger")]
        public static void Run([BlobTrigger("samples-workitems/{name}", Connection = "storage-blob-connection")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
