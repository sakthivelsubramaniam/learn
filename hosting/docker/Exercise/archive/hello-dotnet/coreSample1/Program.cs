using System;
using System.Threading.Tasks;
using System.Threading;

namespace coreSample1
{
    class Program
    {
       
        static  void  Main(string[] args)
        {
            Console.WriteLine("Hello World! -3");
            Thread.Sleep(5000);    

            for(int i =0; i< 10; i++)
            {
                Thread.Sleep(1000);
                try
                {
                    Console.WriteLine($"ello world - inside the loop");
                } 
                catch (Exception e)
                {
                    Console.WriteLine($" http request failed {e.Message}");
                }   
            }

        }

    }
}
