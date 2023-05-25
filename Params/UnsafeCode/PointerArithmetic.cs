using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
	public class PointerArithmetic
	{
		unsafe public static void PointerArithmeticMain()
		{
			Console.WriteLine("\n=== Pointer Arithmetic ===");

			int x;
			int y;
			double d;

			int* ip = &y;
			double* fp = &d;

			Console.WriteLine("int\t   double\n");

			//int is encreased by 4, becouse int is 4 byes
			//double is encreased by 8, because double is 8 bytes
			for (x = 0; x < 10; x++)
			{
				Console.WriteLine((uint)(ip) + " " + (uint)(fp));
				ip++;
				fp++;
			}
		}
	}
}
