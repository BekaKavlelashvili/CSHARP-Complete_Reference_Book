using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class Substring
    {
        public static void SubstringMain()
        {
            Console.WriteLine("\n=== Substring ===");

            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("str: " + str);

            Console.Write("str.Substring(15): ");
            string substr = str.Substring(15);
            Console.WriteLine(substr);

            Console.Write("str.Substring(0, 15): ");
            substr = str.Substring(0, 15);
            Console.WriteLine(substr);
        }
    }
}
