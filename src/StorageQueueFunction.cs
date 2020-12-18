using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureCliSandbox
{
    public static class StorageQueueFunction
    {
        [FunctionName("StorageQueueFunction")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "storage-queue-connection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
