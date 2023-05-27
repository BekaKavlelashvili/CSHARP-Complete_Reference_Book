using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTypes
{
	public class PartialCLasses
	{
		public static void PartialCLassesMain()
		{
            Console.WriteLine("\n=== Demonstrate partial classes ===");

            XY xy = new XY(1, 2);

            Console.WriteLine(xy.X + ", " + xy.Y);
        }
	}

	partial class XY
	{
		public XY(int a, int b)
		{
			X = a;
			Y = b;
		}
	}

	partial class XY
	{
		public int X { get; set; }
	}

	partial class XY
	{
		public int Y { get; set; }
	}
}
