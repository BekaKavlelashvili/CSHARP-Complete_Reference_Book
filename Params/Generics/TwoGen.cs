using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TwoGen<T, V>
    {
        T obj1;
        V obj2;

        public TwoGen(T obj1, V obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
        }

        public void ShowTypes()
        {
            Console.WriteLine("Type of T is: " + typeof(T));
            Console.WriteLine("Type of V is: " + typeof(V));
        }

        public T GetOb1()
        {
            return obj1;
        }

        public V GetOb2()
        {
            return obj2;
        }
    }
}

public static class TwoGenDemo
{
    public static void TwoGenMain()
    {
        Console.WriteLine("\n=== Two type parameter generic ===");
        TwoGen<int, string> tgOb = new TwoGen<int, string>(119, "Alpha Beta Gamma");

        tgOb.ShowTypes();

        int v = tgOb.GetOb1();
        Console.WriteLine("Value: " + v);

        string str = tgOb.GetOb2();
        Console.WriteLine("Value: " + str);

    }
}
