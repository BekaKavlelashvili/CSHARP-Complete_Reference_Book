using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Linq
{
    static class MyExtMeths
    {
        public static double Reciprocal(this double v)
        {
            return 1.0 / v;
        }

        public static string RevCase(this string s)
        {
            string temp = string.Empty;

            foreach (char ch in s)
            {
                if (Char.IsLower(ch))
                    temp += Char.ToUpper(ch, CultureInfo.CurrentCulture);
                else
                    temp += Char.ToLower(ch, CultureInfo.CurrentCulture);
            }

            return temp;
        }

        public static double AbsDivideBy(this double v, double d)
        {
            return Math.Abs(v / d);
        }
    }

    public class ExtensionMethods
    {
        public static void ExtensionMethodsMain()
        {
            Console.WriteLine("\n=== Extension Methods ===");

            double val = 8.0;
            string str = "Alpha Beta Gamma";

            //it's possible
            //8.0.Reciprocal();
            //8.0.AbsDivideBy(-1);
            //"AbcD".RevCase();

            Console.WriteLine("Reciprocal of {0} is {1}", val, val.Reciprocal());

            Console.WriteLine(str + " after reversing case is " + str.RevCase());

            Console.WriteLine("Result of val.AbsDivideBy(-2): " + val.AbsDivideBy(-2));
        }
    }
}
