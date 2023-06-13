using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class FormatTimeSpan
    {
        public static void FormatTimeSpanMain()
        {
            Console.WriteLine("\n=== Format TimeSpan ===");

            DateTime start = DateTime.Now;

            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();

            DateTime end = DateTime.Now;

            TimeSpan span = end - start;

            Console.WriteLine("run time: {0:c}", span);
            Console.WriteLine("run time: {0:g}", span);
            Console.WriteLine("run time: {0:G}", span);

            Console.WriteLine("Run time: 0.{0:fff} seconds", span);
        }
    }
}
