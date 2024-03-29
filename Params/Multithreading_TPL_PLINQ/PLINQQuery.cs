﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_TPL_PLINQ
{
    public class PLINQQuery
    {
        public static void PLINQQueryMain()
        {
            Console.WriteLine("\n=== PLINQ Query ===");

            int[] data = new int[10000000];

            for (int i = 0; i < data.Length; i++) data[i] = i;

            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;

            var negatives = from val in data.AsParallel()
                            where val < 0
                            select val;

            foreach (var item in negatives)
                Console.Write(item + " ");

            Console.WriteLine();
        }
    }
}
