using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace Learn.TimerSample
{
    class TimerState
    {
        public int Counter;
    }


    class CallBackTimerSample1
    {
          private static Timer timer;

         public void Run()
        {
            var timerState = new TimerState { Counter = 0 };

            timer = new Timer(
                callback: new TimerCallback(TimerTask),
                state: timerState,
                dueTime: 1000,
                period: 1000);

            while (timerState.Counter <= 10)
            {
                Task.Delay(1000).Wait();
            }

            timer.Dispose();
            Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: done.");
        }

        private static void TimerTask(object timerState)
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: starting a new callback.");
            var state = timerState as TimerState;
            Interlocked.Increment(ref state.Counter);
        }
   

    }


}