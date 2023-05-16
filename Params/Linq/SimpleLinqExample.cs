using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class SimpleLinqExample
    {
        public static void SimpleLinqExampleMain()
        {
            Console.WriteLine("\n=== Simple query example ===");

            int[] nums = { 1, -2, 3, 0, -4, 5 };

            var posNums = from n in nums
                          where n > 0
                          select n;

            Console.Write("The positive values in nums: ");

            foreach (var num in posNums)
                Console.Write(num + " ");

            Console.WriteLine();

            Console.WriteLine("\nSetting nums[1] to 99.");
            nums[1] = 99;

            Console.Write("The positive values in nums after change: ");

            foreach (var num in posNums)
                Console.Write(num + " ");

            Console.WriteLine();
        }
    }
}
