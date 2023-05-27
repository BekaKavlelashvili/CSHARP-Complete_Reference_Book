using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
	public class DemonstrateNullableType
	{
		public static void DemonstrateNullableTypeMain()
		{
            Console.WriteLine("\n=== Simple Nullable types example ===");
            int? count = null;

			if(count.HasValue)
                Console.WriteLine("count has this value: " + count.Value);
			else
                Console.WriteLine("count has no value.");

			count = 10;

			if(count.HasValue )
                Console.WriteLine("count has this value: "  + count.Value);
			else
                Console.WriteLine("count has no value");
        }
	}
}
