using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    struct XY<T>
    {
        T x;
        T y;

        public XY(T a, T b)
        {
            x = a;
            y = b;
        }

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }
    }

    public static class GenericStructure
    {
        public static void GenericStructureMain()
        {
            Console.WriteLine("\n=== Generic Structure ===");

            XY<int> xY = new XY<int>(10, 20);
            XY<double> xY1 = new XY<double>(88.0, 99.0);

            Console.WriteLine(xY.X + ", " + xY.Y);
            Console.WriteLine(xY1.X + ", " + xY1.Y);
        }
    }
}
