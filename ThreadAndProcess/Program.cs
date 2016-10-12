using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadAndProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ThreadAndTimerinThread
            //DateTime dt = DateTime.Now;
            //int minutes = dt.Second;
            //int milsec = dt.Millisecond;
            //ThreadPriorityX lowerThread = new ThreadPriorityX("lower");
            //lowerThread.thrd.Priority = System.Threading.ThreadPriority.Lowest;
            //ThreadPriorityX aboou = new ThreadPriorityX("Abou");
            //aboou.thrd.Priority = System.Threading.ThreadPriority.AboveNormal;
            //TimerThread timer = new TimerThread("myTimer");
            //timer.thrd.Priority = System.Threading.ThreadPriority.Normal;
            //timer.thrd.Start();
            //lowerThread.thrd.Start();
            //aboou.thrd.Start();
            //timer.thrd.Join();
            //lowerThread.thrd.Join();
            //aboou.thrd.Join();
            //Console.WriteLine(
            //    );
            //Console.WriteLine("The thread is " + timer.thrd.Name);
            //Console.WriteLine("The thread is " + lowerThread.thrd.Name + " count to = " + lowerThread.count);
            //Console.WriteLine("The thread is " + aboou.thrd.Name + " count to = " + aboou.count);
            //dt = DateTime.Now;
            //Console.WriteLine("Time = " + (dt.Second - minutes) + "seconds and " + (dt.Millisecond - milsec) + " millisecond"); 
            #endregion

            #region Lock последовательное выполнение потоков в следствии обработки инструкции lock
            //int[] test_arr= {10, 200, 39, 21, 14, 61};
            //MyThread mt = new MyThread("First Thread", test_arr);
            //MyThread mt1 = new MyThread("Second Thread", test_arr);
            //mt1.thrd.Join();

            //mt.thrd.Join();

            #endregion

            #region (Monitor) тик-так
            MonitorExample me = new MonitorExample();
            MyThreadMonitor mtm = new MyThreadMonitor("tick", me);
            MyThreadMonitor mtm1 = new MyThreadMonitor("tock", me);
       
            mtm.thrd.Join();
           
            mtm1.thrd.Join();
            #endregion
            Console.ReadKey();
        }
    }
}
