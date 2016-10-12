using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadAndProcess
{
    class TimerThread
    {
        public string processName;
        public Thread thrd;
        public int count = 0;
        public TimerThread(string name)
        {
            thrd = new Thread(new ThreadStart(this.Run));
            thrd.Name = name;
            processName = name;
            
        }

        void Run()
        {
            Console.WriteLine("Timer " + thrd.Name + "is Started");
            do
            {
                count++;
                DateTime dt = DateTime.Now;
                Console.WriteLine(dt.ToString("T"));
                Thread.Sleep(1000);

            }
            while (count < 1000000000);
            Console.WriteLine();
            Console.WriteLine("Time is over");
        }
    
    }

}
