using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;


namespace Learn.BenchMarkServiceSub
{
    public class Tracer
    {
        static ConcurrentBag<string> bag = new ConcurrentBag<string>(); 
        static ConcurrentBag<string> errorBag = new ConcurrentBag<string>(); 

        public static void LogInfo(string item)
        {
                bag.Add(item);
        }

        public static void LogError(string item)
        {
            errorBag.Add(item);
        }

        public static IEnumerable<string> GetLogItems()
        {
             return bag.AsEnumerable();
        }

        public static IEnumerable<string> GetErrorItems()
        {
              return errorBag.AsEnumerable();  
        }
    }
    
}