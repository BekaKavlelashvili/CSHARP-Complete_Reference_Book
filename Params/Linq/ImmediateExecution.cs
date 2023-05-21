using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ImmediateExecution
    {
        public static void ImmediateExecutionMain()
        {
            Console.WriteLine("\n=== Immediate Execution ===");

            int[] nums = { 1, -2, 3, 0, -4, 5 };

            int len = (from num in nums
                       where num > 0
                       select num).Count();

            Console.WriteLine("The number of positive values in nums: " + len);
        }
    }
}
