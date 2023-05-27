using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTypes
{
	public class PartialMethods
	{
		public static void PartialMethodsMain()
		{
            Console.WriteLine("\n=== Partial Methods ===");

            XY2 xY2 = new XY2(1, 2);

			xY2.ShowXY();
        }
	}

	partial class XY2
	{
        public XY2(int a, int b)
        {
			X = a;
			Y = b;
        }

		partial void Show();
    }

	partial class XY2
	{
        public int X { get; set; }

		partial void Show()
		{
            Console.WriteLine("{0}, {1}", X, Y);
        }
	}

	partial class XY2
	{
        public int Y { get; set; }	

		public void ShowXY()
		{
			Show();
		}
    }
}
