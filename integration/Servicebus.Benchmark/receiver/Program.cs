using System;
using System.Threading.Tasks;
using Learn.TimerSample;
using BenchmarkDotNet.Running;
using Learn.Integration.ServiceBus;
using BenchmarkDotNet.Attributes;

namespace servicebusBenchmark
{
    class Program
    {
        public static async Task Main(string[] args)
        {
           
            var serviceBusReceiver = new ServiceBusReceiver();
             await serviceBusReceiver.MainAsync();
            Console.ReadKey();

            //var summary = BenchmarkRunnerCore.Run<ServiceBusBenchMark>();
            //var summary = BenchmarkRunner.Run<ServiceBusBenchMark>();

        }


        
    }

}
