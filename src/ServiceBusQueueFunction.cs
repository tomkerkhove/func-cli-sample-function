using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureCliSandbox
{
    public static class ServiceBusQueueFunction
    {
        [FunctionName("ServiceBusQueueFunction")]
        public static void Run([ServiceBusTrigger("myqueue", Connection = "service-bus-queue-connection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
