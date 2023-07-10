using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class UseCancellation
    {
        static void MyTask(Object ob)
        {
            CancellationToken cancellation = (CancellationToken)ob;

            cancellation.ThrowIfCancellationRequested();

            Console.WriteLine("MyTask() starting");

            for (int i = 0; i < 10; i++)
            {
                if (cancellation.IsCancellationRequested)
                {
                    Console.WriteLine("Cancellation request received.");
                    cancellation.ThrowIfCancellationRequested();
                }

                Thread.Sleep(500);
                Console.WriteLine("In MyTask(), count is " + i);
            }

            Console.WriteLine("MyTask terminating");
        }

        public static void UseCancellationMain()
        {
            Console.WriteLine("\n=== Use Cancellation ===");

            Console.WriteLine("\nMain Thread starting");

            CancellationTokenSource cts = new CancellationTokenSource();

            Task ts = Task.Factory.StartNew(MyTask, cts.Token, cts.Token);

            Thread.Sleep(2000);

            try
            {
                cts.Cancel();
                ts.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("\nTask Cancelled\n");
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                ts.Dispose();
                cts.Dispose();
            }

            Console.WriteLine("Main thread ending");
        }
    }
}
