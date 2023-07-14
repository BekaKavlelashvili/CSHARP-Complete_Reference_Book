using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class UseParallelForeach
    {
        static int[] data;

        static void DisplayData(int v, ParallelLoopState pls)
        {
            if (v < 0)
                pls.Break();

            Console.WriteLine("Value: " + v);
        }

        public static void UseParallelForeachMain()
        {
            Console.WriteLine("\n=== Use Parallel.Foreach() ===");

            Console.WriteLine("\nMain thread starting");

            data = new int[100000000];

            for (int i = 0; i < data.Length; i++) data[i] = i;

            data[100000] = -10;

            ParallelLoopResult loopResult = Parallel.ForEach(data, DisplayData);

            if (!loopResult.IsCompleted)
                Console.WriteLine("\nLoop terminated early because a negative value was encountered in iteration number " + loopResult.LowestBreakIteration);

            Console.WriteLine("\nMain thread ending");
        }
    }
}
