﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class UseParallelFor
    {
        static int[] data;

        static void MyTransform(int i)
        {
            data[i] = data[i] / 10;

            if (data[i] < 10000) data[i] = 0;
            if (data[i] > 10000 && data[i] < 20000) data[i] = 100;
            if (data[i] > 20000 && data[i] < 30000) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }

        public static void UseParallelForMain()
        {
            Console.WriteLine("\n=== Use Parallel.For() ===");

            Console.WriteLine("\nMain thread starting");

            Stopwatch sw = new Stopwatch();

            data = new int[100000000];

            sw.Start();

            //parallel for
            Parallel.For(0, data.Length, (i) => data[i] = i);

            sw.Stop();
            Console.WriteLine("Parallel initialization loop :  {0} secs ", sw.Elapsed.TotalSeconds);

            sw.Reset();
            sw.Start();

            for (int i = 0; i < data.Length; i++) data[i] = i;
            sw.Stop();

            Console.WriteLine("Sequential initialization loop: {0} secs", sw.Elapsed.TotalSeconds);
            Console.WriteLine();

            sw.Start();

            Parallel.For(0, data.Length, MyTransform);
            sw.Stop();

            Console.WriteLine("Parallel transform loop: {0} secs", sw.Elapsed.TotalSeconds);

            sw.Reset();
            sw.Start();

            for (int i = 0; i < data.Length; i++) MyTransform(i);
            sw.Stop();

            Console.WriteLine("Sequential transform loop: {0} secs", sw.Elapsed.TotalSeconds);

            Console.WriteLine("Main thread ending");
        }
    }
}
