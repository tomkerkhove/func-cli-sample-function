using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Kafka;
using Microsoft.Extensions.Logging;

namespace AzureCliSandbox
{
    public class KafkaFunction
    {
        [FunctionName("KafkaFunction")]
        public void ProcessEvent(
            [KafkaTrigger(
                "LocalBroker",
                "stringTopicTenPartitions",
                ConsumerGroup = "$Default",
                AuthenticationMode = BrokerAuthenticationMode.Plain)] KafkaEventData<string>[] kafkaEvents,
            ILogger logger)
        {
            foreach (var kafkaEvent in kafkaEvents)
                logger.LogInformation(kafkaEvent.Value.ToString());
        }
    }
}
