using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyTestClass : IComparable<MyTestClass>, IEquatable<MyTestClass>
    {
        public int Val;

        public MyTestClass(int x) { Val = x; }

        public int CompareTo(MyTestClass other)
        {
            return Val - other.Val;
        }

        public bool Equals(MyTestClass other)
        {
            return Val == other.Val;
        }

        public override bool Equals(Object obj)
        {
            if (obj is MyTestClass)
                return Equals((MyTestClass)obj);

            return false;
        }

        public override int GetHashCode()
        {
            return Val.GetHashCode();
        }
    }

    public class CompareInstancesOfATypeParam
    {
        public static bool IsIn<T>(T what, T[] obs) where T : IEquatable<T>
        {
            foreach (T v in obs)
                if (v.Equals(what))
                    return true;

            return false;
        }

        public static bool InRange<T>(T what, T[] obs) where T : IComparable<T>
        {
            if (what.CompareTo(obs[0]) < 0 || what.CompareTo(obs[obs.Length - 1]) > 0)
                return false;

            return true;
        }

        public static void CompareInstancesOfATypeParamMain()
        {
            Console.WriteLine("\n=== Compare Instances Of a Type Parameters");

            int[] nums = { 1, 2, 3, 4, 5 };

            if (IsIn(2, nums))
                Console.WriteLine("2 is found.");

            if (IsIn(99, nums))
                Console.WriteLine("This won't display.");

            MyTestClass[] mcs = { new MyTestClass(1), new MyTestClass(2), new MyTestClass(3), new MyTestClass(4) };

            if (IsIn(new MyTestClass(3), mcs))
                Console.WriteLine("MyTestClass(3) is found.");

            if (IsIn(new MyTestClass(99), mcs))
                Console.WriteLine("This won't display.");


            if (InRange(2, nums))
                Console.WriteLine("2 is within the range of nums.");

            if (InRange(1, nums))
                Console.WriteLine("1 is within the range of nums.");

            if (InRange(5, nums))
                Console.WriteLine("5 is within the range of nums.");

            if (!InRange(0, nums))
                Console.WriteLine("0 is NOT within the range of nums.");

            if (!InRange(6, nums))
                Console.WriteLine("6 is NOT within the range of nums.");

            if (InRange(new MyTestClass(2), mcs))
                Console.WriteLine("MyClass(2) is within the range of mcs.");

            if (InRange(new MyTestClass(1), mcs))
                Console.WriteLine("MyClass(1) is within the range of mcs.");

            if (InRange(new MyTestClass(4), mcs))
                Console.WriteLine("MyClass(4) is within the range of mcs.");

            if (!InRange(new MyTestClass(0), mcs))
                Console.WriteLine("MyClass(0) is NOT within the range of mcs.");

            if (!InRange(new MyTestClass(5), mcs))
                Console.WriteLine("MyClass(5) is NOT within the range of mcs.");
        }
    }
}
