using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Learn.BenchMarkServiceSub
{
    class Program
    {
        public  static void Main(string[] args)
        {
            Console.WriteLine("Sender async");
            var summary = BenchmarkRunner.Run(typeof(ServiceBusSender));

            // var sender = new ServiceBusSender();
            // sender.ExeSender();

        }

       
    }
}
