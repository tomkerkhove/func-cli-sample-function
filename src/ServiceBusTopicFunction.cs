using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureCliSandbox
{
    public static class ServiceBusTopicFunction
    {
        [FunctionName("ServiceBusTopicFunction")]
        public static void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "service-bus-topic-connection")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
