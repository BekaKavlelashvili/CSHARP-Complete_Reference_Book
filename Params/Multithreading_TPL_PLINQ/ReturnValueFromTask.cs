using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class ReturnValueFromTask
    {
        static bool MyTask()
        {
            return true;
        }

        static int SumIt(object v)
        {
            int x = (int)v;
            int sum = 0;

            for (; x > 0; x--)
                sum += x;

            return sum;
        }

        public static void ReturnValueFromTaskMain()
        {
            Console.WriteLine("\n=== Return Value From Task ===");

            Console.WriteLine("\nMain thread starting.");

            Task<bool> tsk = Task<bool>.Factory.StartNew(MyTask);

            Console.WriteLine("\nAfter running MyTask. the result is " + tsk.Result);

            Task<int> tsk2 = Task<int>.Factory.StartNew(SumIt, 3);

            Console.WriteLine("After running SumIt. The result is " + tsk2.Result);

            tsk.Dispose();
            tsk2.Dispose();

            Console.WriteLine("Main thread ending.");
        }
    }
}
