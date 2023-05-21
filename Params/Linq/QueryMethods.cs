using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class QueryMethods
    {
        static void WhereAndSelect()
        {
            Console.WriteLine("\n=== Where and Select Query Methods ===");

            int[] nums = { 1, -2, 3, 0, -4, 5 };

            var posNums = nums.Where(x => x > 0).Select(x => x);

            Console.Write("The positive values in nums: ");

            foreach (int i in posNums)
                Console.Write(i + " ");

            Console.WriteLine();
        }

        static void GroupBy()
        {
            Console.WriteLine("\n=== GroupBy Query Method ===");

            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                     "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                     "hsNameG.tv", "hsNameH.net", "hsNameI.tv" };

            var webAddrs = websites.Where(x=> x.LastIndexOf('.') != -1).GroupBy(x=> x.Substring(x.LastIndexOf(".")));

            foreach (var sites in webAddrs)
            {
                Console.WriteLine("Web sites grouped by " + sites.Key);
                foreach (var site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }

        static void ExtMethods()
        {
            Console.WriteLine("\n=== Extension Methods ===");

            int[] nums = { 3, 1, 2, 5, 4 };
            Console.WriteLine("The minimum value is " + nums.Min());
            Console.WriteLine("The maximum value is " + nums.Max());

            Console.WriteLine("The first value is " + nums.First());
            Console.WriteLine("The last value is " + nums.Last());

            Console.WriteLine("The sum is " + nums.Sum());
            Console.WriteLine("The average is " + nums.Average());

            if(nums.All(x => x > 0))
                Console.WriteLine("All values are greater than 0.");

            if(nums.Any(x => (x % 2) == 0))
                Console.WriteLine("At least one value is even.");

            if(nums.Contains(3))
                Console.WriteLine("The array contains 3.");
        }

        public static void QueryMethodsMain()
        {
            Console.WriteLine("\n=== Query Methods ===\n");
            WhereAndSelect();
            GroupBy();
            ExtMethods();
        }
    }
}
