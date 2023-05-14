using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Generics
{
    public interface ISeries<T>
    {
        T GetNext();
        void Reset();
        void SetStart(T v);
    }

    class ByTwos<T> : ISeries<T>
    {
        T start;
        T val;

        public delegate T IncByTwo(T v);

        IncByTwo incr;

        public ByTwos(IncByTwo incrMeth)
        {
            start = default(T);
            val = default(T);
            incr = incrMeth;
        }

        public T GetNext()
        {
            val = incr(val);
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(T v)
        {
            start = v;
            val = start;
        }
    }

    class ThreeD
    {
        public int x, y, z;

        public ThreeD(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }


    public class GenericInterface
    {
        static int IntPlusTwo(int v)
        {
            return v + 2;
        }

        static double DoublePlusTwo(double v)
        {
            return v + 2.0;
        }

        static ThreeD ThreeDPlusTwo(ThreeD v)
        {
            if (v == null)
                return new ThreeD(0, 0, 0);
            else
                return new ThreeD(v.x + 2, v.y + 2, v.z + 2);
        }

        public static void GenericInterfaceMain()
        {
            Console.WriteLine("\n=== Generic Interface ===");

            ByTwos<int> intBT = new ByTwos<int>(IntPlusTwo);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(intBT.GetNext() + " ");
            }

            Console.WriteLine();

            ByTwos<double> doubleBT = new ByTwos<double>(DoublePlusTwo);
            doubleBT.SetStart(11.4);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(doubleBT.GetNext() + " ");
            }

            Console.WriteLine();

            ByTwos<ThreeD> thrBT = new ByTwos<ThreeD>(ThreeDPlusTwo);
            ThreeD coord;

            for (int i = 0; i < 5; i++)
            {
                coord = thrBT.GetNext();
                Console.Write(coord.x + "," + coord.y + "," + coord.z + " ");
            }

            Console.WriteLine();
        }
    }
}
