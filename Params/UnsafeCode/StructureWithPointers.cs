using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
	struct MyStruct
	{
		public int a;
		public int b;

		public int Sum()
		{
			return a + b;
		}
	}

	public class StructureWithPointers
	{
		unsafe public static void StructureWithPointersMain()
		{
			Console.WriteLine("\n=== Structure And Pointer ===");

			MyStruct o = new MyStruct();
			MyStruct* p;

			p = &o;
			p -> a = 10;
			p -> b = 20;

			Console.WriteLine("Sum is: " + p->Sum());
		}
	}
}
