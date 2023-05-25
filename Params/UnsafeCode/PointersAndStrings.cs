using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
	public class PointersAndStrings
	{
		unsafe public static void PointersAndStringsMain()
		{
			Console.WriteLine("\n=== Pointers and Strings ===");

			string str = "This is a test";

			fixed(char* p = str)
			{
				for (int i = 0; p[i] != 0; i++)
				{
					Console.Write(p[i]);
				}
			}
			Console.WriteLine();
		}
	}
}
