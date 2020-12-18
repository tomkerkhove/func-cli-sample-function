using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureCliSandbox
{
    public static class RabbitMQFunction
    {
        [FunctionName("RabbitMQFunction")]
        public static void Run([RabbitMQTrigger("myqueue", ConnectionStringSetting = "rabbit-connection-string-setting")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
