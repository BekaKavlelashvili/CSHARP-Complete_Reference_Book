using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
	public class PointersAndArrays
	{
		unsafe public static void PointersAndArraysMain()
		{
			Console.WriteLine("\n=== Pointer and Array ===");
			int[] nums = new int[10];

			fixed (int* p = &nums[0], p2 = nums) //second form is just short, in this case nums means first element of nums[] array inseated of whole array
			{
				if(p == p2)
					Console.WriteLine("p and p2 point to same address");
			}
		}
	}
}
