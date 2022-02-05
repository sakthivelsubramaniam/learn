using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Azure.ServiceBus;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Learn.BenchMarkServiceSub
{
    public class ServiceBusSender
    {

        private string ServiceBusConnectionString = "Endpoint=sb://saksbns.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=HA79nIQ22jRwc9IJbaAoyu9nI5+IRTnsWYzcUDpUiy0=";
        private string QueueName = "saksb";

         IQueueClient queueClient;

        public ServiceBusSender()
        {
            queueClient =  new QueueClient(ServiceBusConnectionString, QueueName);
        }

 
         [Benchmark]
        public  void ExeSender()
        {
                
            SendMessagesAsync(1).Wait();
        }
       public async Task SendMessagesAsync(int execNo)
       {
            try
            {
                    // Create a new message to send to the queue.
                    string messageBody = $"Message {execNo}";
                    var message = new Message(Encoding.UTF8.GetBytes(messageBody));

                    // Send the message to the queue.
                    await queueClient.SendAsync(message);

                    Tracer.LogInfo($"{DateTime.Now}::Message Sent");
                  //  await queueClient.CloseAsync();
            }
            catch (Exception exception)
            {
                Tracer.LogError($"{DateTime.Now} :: Exception: {exception.Message}");
            }
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        { 
                       File.WriteAllText( @"D:\\code\log.txt",string.Join( Environment.NewLine, Tracer.GetLogItems()));
           File.AppendAllText( @"D:\\code\log.txt",string.Join( Environment.NewLine, Tracer.GetErrorItems()));


        }
        
        
    }

    //https://github.com/dotnet/BenchmarkDotNet
    
}