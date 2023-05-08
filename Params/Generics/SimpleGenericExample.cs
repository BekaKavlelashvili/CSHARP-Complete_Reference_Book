using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class SimpleGenericExample<T>
    {
        T ob;

        public SimpleGenericExample(T o)
        {
            ob = o;
        }

        public T GetOb()
        {
            return ob;
        }

        public void ShowType()
        {
            Console.WriteLine("Type of T is " + typeof(T));
        }
    }
}

static class SimpleGenericExampleDemo
{
    public static void SimpleGenericExampleMain()
    {
        SimpleGenericExample<int> ioOb;
        ioOb = new SimpleGenericExample<int>(102);

        ioOb.ShowType();

        int v = ioOb.GetOb();
        Console.WriteLine("value: " + v);

        Console.WriteLine();

        SimpleGenericExample<string> strob = new SimpleGenericExample<string>("Generics add power.");
        strob.ShowType();

        string str = strob.GetOb();
        Console.WriteLine("value: " + str);
    }
}