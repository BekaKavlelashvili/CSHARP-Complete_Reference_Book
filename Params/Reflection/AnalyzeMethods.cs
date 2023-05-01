using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class AnalyzeMethods
    {
        public int x;
        public int y;

        public AnalyzeMethods(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            return x < i && i < y;
        }

        public void Set(int a, int b)
        {
            x = a;
            y = b;
        }

        public void Set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void Show()
        {
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }

    internal static class AnalyzesMethodsDemo
    {
        public static void MainDemo()
        {
            Type t = typeof(AnalyzeMethods);

            Console.WriteLine("Analyzing methods in " + t.Name);
            Console.WriteLine();

            Console.WriteLine("Methods supported: ");

            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                Console.Write("   " + m.ReturnType.Name + " " + m.Name + "(");
                ParameterInfo[] pi = m.GetParameters();

                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);

                    if (i + 1 < pi.Length)
                        Console.Write(", ");
                }

                Console.WriteLine(")");
                Console.WriteLine();
            }
        }
    }
}
