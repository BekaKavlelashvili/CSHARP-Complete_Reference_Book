using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Strings_And_Formatting
{
    public class DemonstrateToString
    {
        public static void DemonstrateToStringMain()
        {
            Console.WriteLine("\n=== ToString() ===");

            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;

            string str = v.ToString("F2");
            Console.WriteLine(str);

            str = v.ToString("N5");
            Console.WriteLine(str);

            str = v.ToString("e");
            Console.WriteLine(str);

            str = v.ToString("r");
            Console.WriteLine(str);

            str = v2.ToString("p");
            Console.WriteLine(str);

            str = x.ToString("X");
            Console.WriteLine(str);

            str = x.ToString("D12");
            Console.WriteLine(str);

            str = 189.99.ToString("C");
            Console.WriteLine(str);
        }
    }
}
