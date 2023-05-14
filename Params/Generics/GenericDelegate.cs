using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    delegate T SomeOp<T>(T v);

    public class GenericDelegate
    {
        static int Sum(int v)
        {
            int result = 0;

            for (int i = v; i > 0; i--)
                result += i;

            return result;
        }

        static string Reflect(string str)
        {
            string result = string.Empty;

            foreach (char ch in str)
                result = ch + result;

            return result;
        }

        public static void GenericDelegateMain()
        {
            Console.WriteLine("\n=== Generic Delegate ===");

            SomeOp<int> intDel = Sum;
            Console.WriteLine(intDel(3));

            SomeOp<string> strDel = Reflect;
            Console.WriteLine(strDel("Hello"));
        }
    }
}
