using System;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace coreSample1
{
    class Program
    {
         private static readonly HttpClient client = new HttpClient();
        static  void  Main(string[] args)
        {
            Console.WriteLine("Hello World! -3");
            Thread.Sleep(5000);    

            for(int i =0; i< 10; i++)
            {
                Thread.Sleep(1000);
                try
                {
                    var result =  ProcessRepositories();
                    result.Wait();
                } 
                catch (Exception e)
                {
                    Console.WriteLine($" http request failed {e.Message}");
                }   
            }

        }

        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("http://web/api/values");

            var msg = await stringTask;
            Console.Write(msg);
        }
    }
}
