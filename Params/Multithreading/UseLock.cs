using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class SumArray
    {
        int sum;
        object lockOn = new object();

        public int SumIt(int[] nums)
        {
            lock (lockOn)
            {
                sum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    Console.WriteLine("Running total for " + Thread.CurrentThread.Name + " is " + sum);

                    Thread.Sleep(10);
                }
                return sum;
            }
        }
    }

    class MyThread6
    {
        public Thread Thrd;
        int[] a;
        int answer;

        static SumArray sa = new SumArray();

        public MyThread6(string name, int[] nums)
        {
            a = nums;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " starting.");

            answer = sa.SumIt(a);

            Console.WriteLine("Sum for " + Thrd.Name + " is " + answer);
            Console.WriteLine(Thrd.Name + " terminating.");
        }
    }

    public class UseLock
    {
        public static void UseLockMain()
        {
            Console.WriteLine("\n==== Use Lock for Synchronization ===");

            int[] a = { 1, 2, 3, 4, 5 };

            MyThread6 mt1 = new("Child #1", a);
            MyThread6 mt2 = new("Child #2", a);

            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}
