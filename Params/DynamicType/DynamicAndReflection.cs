using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicType
{
	public class DivBy
	{
		public bool IsDivBy(int a, int b)
		{
			if ((a % b) == 0)
				return true;

			return false;
		}

		public bool IsEven(int a)
		{
			if (a % 2 == 0)
				return true;

			return false;
		}
	}

	public class DynamicAndReflection
	{
		public static void DynamicAndReflectionMain()
		{
            Console.WriteLine("\n=== Dynamic types with Reflection ===");

            Assembly asm = Assembly.Load("DynamicType.dll");

			Type[] all = asm.GetTypes();

			int i;

			for (i = 0; i < all.Length; i++)
				if (all[i].Name == "DivBy")
					break;

			if (i == all.Length)
			{
				Console.WriteLine("DivBy not found in assembly");
				return;
			}

			Type t = all[i];

			ConstructorInfo[] ci = t.GetConstructors();

			int j;

			for (j = 0; j < ci.Length; j++)
				if (ci[i].GetParameters().Length == 0)
					break;

			if (j == ci.Length)
			{
                Console.WriteLine("Default constructor not found");
				return;
            }

			dynamic obj = ci[j].Invoke(null);

			if(obj.IsDivBy(15, 3))
                Console.WriteLine("15 is evenly divisible by 3.");
			else
                Console.WriteLine("15 is Not evenly divisible by 3");

			if (obj.IsEven(9))
				Console.WriteLine("9 is even");
			else
				Console.WriteLine("9 is not even");
        }
	}
}
