using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class MyThread
    {
        public int Count;
        string ThrdName;

        public MyThread(string name)
        {
            Count = 0;
            ThrdName = name;
        }

        public void Run()
        {
            Console.WriteLine(ThrdName + " starting.");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + ThrdName + ", count is " + Count);
                Count++;
            } while (Count < 10);

            Console.WriteLine(ThrdName + " terminating.");
        }
    }

    public class DemonstrateThreadClass
    {
        public static void DemonstrateThreadClassMain()
        {
            Console.WriteLine("\n=== Demonstrate Multithreading ===");

            Console.WriteLine("Main thread starting.");

            MyThread thread = new MyThread("Child #1");

            Thread newThread = new Thread(thread.Run);

            newThread.Start();

            do
            {
                Console.Write('.');
                Thread.Sleep(100);
            } while (thread.Count != 10);

            Console.WriteLine("Main thread ending.");
        }
    }
}
