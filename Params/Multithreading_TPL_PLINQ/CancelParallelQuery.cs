using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class CancelParallelQuery
    {
        public static void CancelParallelQueryMain()
        {
            Console.WriteLine("\n=== Cancel Parallel Query ===");

            CancellationTokenSource cancelTokSrc = new CancellationTokenSource();
            int[] data = new int[10000000];

            for (int i = 0; i < data.Length; i++) data[i] = i;

            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;

            var negatives = from val in data.AsParallel().WithCancellation(cancelTokSrc.Token)
                            where val < 0
                            select val;

            Task cancelTask = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(100);
                cancelTokSrc.Cancel();
            });

            try
            {
                foreach (var v in negatives)
                    Console.Write(v + " ");
            }
            catch (OperationCanceledException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (AggregateException exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                cancelTask.Wait();
                cancelTokSrc.Dispose();
                cancelTask.Dispose();
            }

            Console.WriteLine();
        }
    }
}
