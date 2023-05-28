using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicType
{
	public class UseOfDynamic
	{
		public static void UseOfDynamicMain()
		{
            Console.WriteLine("=== Use of dynamic type ===");

            dynamic str;
			dynamic val;

			str = "This is a string.";
			val = 10;

            Console.WriteLine("str contains " + str);
            Console.WriteLine("val contains " + val + '\n');

			str = str.ToUpper(CultureInfo.CurrentCulture);
			Console.WriteLine("str now contains " + str);

			val += 2;
			Console.WriteLine("val now contains " + val + '\n');

			string str2 = str.ToLower(CultureInfo.CurrentCulture);
			Console.WriteLine("str2 contains  " + str2);

			int x = val * 2;
			Console.WriteLine("x contains " + x);
        }
	}
}
