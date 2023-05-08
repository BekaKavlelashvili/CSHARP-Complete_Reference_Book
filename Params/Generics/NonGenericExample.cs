using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class NonGenericExample
    {
        object ob;

        public NonGenericExample(object ob)
        {
            this.ob = ob;
        }

        public object GetOb()
        {
            return ob;
        }

        public void ShowType()
        {
            Console.WriteLine("Type of ob is: " + ob.GetType());
        }
    }
}

public static class NonGenericExampleDemo
{
    public static void NonGenericExampleMain()
    {
        Console.WriteLine("\n=== Simple Non Generics Example ====");

        NonGenericExample iOb;
        iOb = new NonGenericExample(102);

        iOb.ShowType();

        int v = (int)iOb.GetOb();
        Console.WriteLine("value: " + v);

        Console.WriteLine();

        NonGenericExample strOb = new NonGenericExample("Non generics test");
        strOb.ShowType();

        String str = (string)strOb.GetOb();
        Console.WriteLine("value:" + str);

        iOb = strOb;
        
        //runtime exception, iOb is storing string 
        //v = (int)iOb.GetOb();
    }
}
