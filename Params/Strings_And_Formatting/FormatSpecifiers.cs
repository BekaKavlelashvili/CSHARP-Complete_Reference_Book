using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class FormatSpecifiers
    {
        public static void FormatSpecifiersMain()
        {
            Console.WriteLine("\n=== Demonstrate Format Specifiers ===");

            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;

            Console.WriteLine("{0:F2}", v);
            Console.WriteLine("{0:N5}", v);
            Console.WriteLine("{0:e}", v);
            Console.WriteLine("{0:r}", v);
            Console.WriteLine("{0:p}", v2);
            Console.WriteLine("{0:X}", x);
            Console.WriteLine("{0:D12}", x);
            Console.WriteLine("{0:C}", 189.99);
        }
    }
}
