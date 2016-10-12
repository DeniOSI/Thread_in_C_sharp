using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadAndProcess
{
    class MonitorExample //Тик так
    {
        public void Tick(bool running)
        {
            lock (this)
            {
                if (!running) { Monitor.Pulse(this); return; }
                Console.WriteLine("tick");
                Monitor.Pulse(this);
                Monitor.Wait(this);

            }

        }


        public void Tock(bool running)
        {

            lock (this)
            {
                if (!running) { Monitor.Pulse(this); return; }
                Console.WriteLine("tock");
                Monitor.Pulse(this);
                Monitor.Wait(this); 
            }
            
        }
    }
    class MyThreadMonitor
    {
        public Thread thrd;
        MonitorExample ttob;
        public MyThreadMonitor(string name, MonitorExample me)
        {
            thrd = new Thread(new ThreadStart(this.Run));
            thrd.Name = name;
            ttob = me;
            thrd.Start();
        }

        public void Run()
        {
           
           if(thrd.Name == "tick") {
                for(int i = 0; i< 5; i++)
                ttob.Tick(true); ttob.Tick(false);
                Thread.Sleep(1000);
            }
           else { if (thrd.Name == "tock") { for (int i = 0; i < 5; i++)
                     ttob.Tock(true); ttob.Tock(false);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
