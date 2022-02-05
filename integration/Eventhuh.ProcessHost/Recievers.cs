
namespace SampleEphReceiver
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Azure.EventHubs;
    using Microsoft.Azure.EventHubs.Processor;

    public class Recievers {
       

         public static async Task ExecAsync()
         {
            Console.WriteLine("Registering EventProcessor...");

            var eventProcessorHost = new EventProcessorHost(
                Connect.EventHubName,
                PartitionReceiver.DefaultConsumerGroupName,
                Connect.EventHubConnectionString,
                Connect.StorageConnectionString,
                Connect.StorageContainerName);

            // Registers the Event Processor Host and starts receiving messages
            await eventProcessorHost.RegisterEventProcessorAsync<SimpleEventProcessor>();

            Console.WriteLine("Receiving. Press enter key to stop worker.");
            Console.ReadLine();

            // Disposes of the Event Processor Host
            await eventProcessorHost.UnregisterEventProcessorAsync();
         }
    }
}
