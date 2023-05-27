using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
	public class NullableTypesInExpressions
	{
		public static void NullableTypesInExpressionsMain()
		{
            Console.WriteLine("\n=== Nullable types in expression ===");
            int? count = null;
			int? result = null;

			int incr = 10;

			result = count + incr;

			if (result.HasValue)
				Console.WriteLine("result has this value: " + result.Value);
			else
				Console.WriteLine("result has no value");

			count = 100;
			result = count + incr;

			if (result.HasValue)
				Console.WriteLine("result has this value: " + result.Value);
			else
				Console.WriteLine("result has no value");
		}
	}
}
