using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class Use_Parallel_Invoke
    {
        static void MyMeth()
        {
            Console.WriteLine("MyMeth starting");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyMeth() count is " + i);
            }

            Console.WriteLine("MyMeth terminating");
        }

        static void MyMeth2()
        {

            Console.WriteLine("MyMeth2 starting");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyMeth2() count is " + i);
            }

            Console.WriteLine("MyMeth2 terminating");
        }

        public static void Use_Parallel_InvokeMain()
        {
            Console.WriteLine("\n=== Use Parallel.Invoke() ===");

            Console.WriteLine("\nMain thread staring");

            Parallel.Invoke(MyMeth, MyMeth2);

            Console.WriteLine("Main thread ending");
        }
    }
}
