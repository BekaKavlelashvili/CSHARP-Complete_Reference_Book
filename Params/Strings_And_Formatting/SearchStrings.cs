using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class SearchStrings
    {
        static void SearchInStrings()
        {
            Console.WriteLine("\n=== Search in Strings ===");

            string str = "C# has powerful string handling.";
            int idx;

            Console.WriteLine("str: " + str);

            idx = str.IndexOf('h');
            Console.WriteLine("Index of first 'h': " + idx);

            idx = str.LastIndexOf('h');
            Console.WriteLine("Index of last 'h': " + idx);

            idx = str.IndexOf("ing", StringComparison.Ordinal);
            Console.WriteLine("Index of first \"ing\": " + idx);

            idx = str.LastIndexOf("ing", StringComparison.Ordinal);
            Console.WriteLine("Index of last \"ing\": " + idx);

            char[] chars = { 'a', 'b', 'c' };

            idx = str.IndexOfAny(chars);
            Console.WriteLine("Index of first 'a', 'b', or 'c': " + idx);

            if (str.StartsWith("C# has", StringComparison.Ordinal))
                Console.WriteLine("str begins with \"C# has\"");

            if (str.EndsWith("ling.", StringComparison.Ordinal))
                Console.WriteLine("str ends with \"ling.\"");
        }

        static void DemonstrateContains()
        {
            Console.WriteLine("\n=== Demonstrate Contains Method ===");

            string str = "C# combines power with performance.";

            if (str.Contains("power"))
                Console.WriteLine("The sequence power was found.");

            if (str.Contains("pow"))
                Console.WriteLine("The sequence pow was found.");

            if (!str.Contains("powerful"))
                Console.WriteLine("The sequence powerful was not found.");
        }

        public static void SearchStringsMain()
        {
            Console.WriteLine("\n=== Search Strings ===");
            SearchInStrings();
            DemonstrateContains();
        }
    }
}
