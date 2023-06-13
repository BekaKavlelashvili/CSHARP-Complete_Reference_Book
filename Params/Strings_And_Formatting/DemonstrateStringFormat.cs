using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class DemonstrateStringFormat
    {
        public static void DemonstrateStringFormatMain()
        {
            Console.WriteLine("\n=== String.Format() ===");

            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;

            string str = string.Format("{0:F5}", v);
            Console.WriteLine(str);

            str = string.Format("{0:N5}", v);
            Console.WriteLine(str);

            str = string.Format("{0:e}", v);
            Console.WriteLine(str);

            str = string.Format("{0:r}", v);
            Console.WriteLine(str);

            str = string.Format("{0:p}", v2);
            Console.WriteLine(str);

            str = string.Format("{0:X}", x);
            Console.WriteLine(str);

            str = String.Format("{0:D12}", x);
            Console.WriteLine(str);

            str = string.Format("{0:C}", 189.99);
            Console.WriteLine(str);
        }
    }
}
