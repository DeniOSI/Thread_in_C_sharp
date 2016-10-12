using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadAndProcess
{
    class ThreadPriorityX
    {
        public int count;
        public Thread thrd;
        public bool stop = false;
        static string currentName;

        public ThreadPriorityX(string name)
        {
            
            thrd = new Thread(new ThreadStart(this.Run));
            count = 0;
            thrd.Name = name; currentName = name;
        }

        public void Run()
        {
            Console.WriteLine("Thread " + thrd.Name + "is started.");
            do
            {
                count++;
                if (currentName != thrd.Name)
                {
                    currentName = thrd.Name;
                    Thread.Sleep(1000);
                    Console.WriteLine("In thread now is" + currentName);
                }

            }
            while (stop == false && count < 1000000000);
            stop = true;
           Console.WriteLine("Thread is: " + currentName + "is Finished.");
        }
    }
}
