using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
	public class MultipleIndirect
	{
		unsafe public static void MultipleIndirectMain()
		{
			Console.WriteLine("\n=== Multiple Indirect ===");

			int x;
			int* p;
			int** q;

			x = 10;
			p = &x;
			q = &p;

			Console.WriteLine(**q);
		}
	}
}
