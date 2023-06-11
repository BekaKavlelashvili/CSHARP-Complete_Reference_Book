using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class TrimmingAndPadding
    {
        public static void TrimmingAndPaddingMain()
        {
            Console.WriteLine("\n=== Trimming and Paddind ===");

            string str = "test";
            Console.WriteLine("Original string: " + str);

            str = str.PadLeft(10);
            Console.WriteLine("|" + str + "|");

            str = str.PadRight(20);
            Console.WriteLine("|" + str + "|");

            str = str.Trim();
            Console.WriteLine("|" + str + "|");

            str = str.PadLeft(10, '#');
            Console.WriteLine("|" + str + "|");

            str = str.PadRight(20, '#');
            Console.WriteLine("|" + str + "|");

            str = str.Trim('#');
            Console.WriteLine("|" + str + "|");
        }
    }
}
