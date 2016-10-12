using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadAndProcess
{
    class loockThread
    {
        int i_sum;

        public int sumIt(int[] nums)
        { 
            //lock(this){
                i_sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {

                    i_sum += nums[i];
                    Console.WriteLine("Промежуточная сумма для потока {0}, равна {1}", Thread.CurrentThread.Name, i_sum);
                    Thread.Sleep(10);
                }
                return i_sum;
            //}
        }

    }


    //class MyThread
    //{
    //    public Thread thrd;
    //    public string currentName;
    //    int[] value;
    //    static loockThread lt = new loockThread();
    //    public MyThread(string threadName, int[] Value)
    //    {
    //        thrd = new Thread(new ThreadStart(this.Run));
    //        currentName = threadName;
    //        thrd.Name = currentName;
    //        thrd.Start();
    //        this.value = Value;


    //    }

    class MyThread
    {
        public Thread thrd;
        public string currentName;
        int[] value;
        static loockThread lt = new loockThread();
        public MyThread(string threadName, int[] Value)
        {
            thrd = new Thread(new ThreadStart(this.Run));
            currentName = threadName;
            thrd.Name = currentName;
            thrd.Start();
            this.value = Value;


        }

        public void Run()
        {
            int i_temp;
            lock (lt) i_temp =  lt.sumIt(value);
            
            Console.WriteLine("Поток {0} стартовал", thrd.Name);
            Console.WriteLine("Сумма для потока {0} = {1}", thrd.Name, i_temp);
            Console.WriteLine("Поток {0} завершен", thrd.Name);
        
        }
        
    }
}
