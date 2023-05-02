using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class InvokeMethods
    {
        public int x;
        public int y;

        public InvokeMethods(int x, int y)
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
            Console.WriteLine("Inside Set(int, int).");
            x = a;
            y = b;
            Show();
        }

        public void Set(double a, double b)
        {
            Console.Write("Inside Set(double, double). ");
            x = (int)a;
            y = (int)b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Values are x: {0}, y: {1}", x, y);
        }
    }

    internal static class InvokeMethodsDemo
    {
        public static void MainDemo()
        {
            Console.WriteLine("=== Invoke Methods ===");

            Type t = typeof(InvokeMethods);

            InvokeMethods reflectOb = new InvokeMethods(10, 20);
            int val;

            Console.WriteLine("Invoking methods in " + t.Name);
            Console.WriteLine();
            MethodInfo[] mi = t.GetMethods();

            foreach (MethodInfo m in mi)
            {
                ParameterInfo[] pi = m.GetParameters();

                if (m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(int))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(double))
                {
                    object[] args = new object[2];
                    args[0] = 1.12;
                    args[1] = 23.4;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.Equals("Sum", StringComparison.Ordinal))
                {
                    val = (int)m.Invoke(reflectOb, null);
                    Console.WriteLine("sum is " + val);
                }
                else if (m.Name.Equals("IsBetween", StringComparison.Ordinal))
                {
                    object[] args = new object[1];
                    args[0] = 14;
                    if ((bool)m.Invoke(reflectOb, args)) ;
                    Console.WriteLine("14 is between x and y");
                }
                else if (m.Name.Equals("Show", StringComparison.Ordinal))
                {
                    m.Invoke(reflectOb, null);
                }
            }
        }
    }
}

