using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
	public class NullCoalescingOperator
	{
		static double GetZeroBal()
		{
            Console.WriteLine("In GetZeroBal().");
			return 0.0;
        }

		public static void NullCoalescingOperatorMain()
		{
            Console.WriteLine("\n=== Null Coalescing Operator ===");

            double? balance = 123.75;
			double currentBalance;

			currentBalance = balance ?? GetZeroBal();

            Console.WriteLine(currentBalance);
        }
	}
}
