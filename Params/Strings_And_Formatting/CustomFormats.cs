using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class CustomFormats
    {
        public static void CustomFormatsMain()
        {
            Console.WriteLine("\n=== Create Custom Formats ===");

            double num = 64354.2345;
            Console.WriteLine("Default format: " + num);

            Console.WriteLine("Value with two decimal places: " + "{0:#.##}", num);

            Console.WriteLine("Add commas: " + "{0:#,###.##}", num);

            Console.WriteLine("Use scientific notation:" + "{0:#.###e+00}", num);

            Console.WriteLine("Value in 1,000s: " + "{0:#0,}", num);

            Console.WriteLine("Display positive, negative, " + "and zero values differently.");

            Console.WriteLine("{0:#.#;(#.##);0.00}", num);

            num = -num;
            Console.WriteLine("{0:#.##;(#.##);0.00}", num);

            num = 0.0;
            Console.WriteLine("{0:#.##;(#.##);0.00}", num);

            num = 0.17;
            Console.WriteLine("Display a percentage: {0:#%}", num);
        }
    }
}
