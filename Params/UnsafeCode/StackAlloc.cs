using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
	public class StackAlloc
	{
		unsafe public static void StackAllocMain()
		{
			Console.WriteLine("\n=== Memory allocate from the Stack");

			int* ptrs  = stackalloc int[3];
			ptrs[0] = 1;
			ptrs[1] = 2;
			ptrs[2] = 3;

			for (int i = 0; i < 3; i++)
				Console.WriteLine(ptrs[i]);
		}
	}
}
