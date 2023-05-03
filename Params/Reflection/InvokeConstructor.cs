using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Reflection
{
    internal class InvokeConstructor
    {
        public int x;
        public int y;
        public InvokeConstructor(int i)
        {
            Console.WriteLine("Constructing InvokeConstructor(int, int).");
            x = y = i;
        }

        public InvokeConstructor(int x, int y)
        {
            Console.WriteLine("Constructing InvokeConstructor(int, int).");
            this.x = x;
            this.y = y;
            Show();
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
            Console.Write("Inside Set(int, int).");
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

    public static class InvokeConstructorDemo
    {
        public static void MainDemo()
        {
            Console.WriteLine("\n=== Invoke Constructor ===");

            Type t = typeof(InvokeConstructor);
            int val;

            ConstructorInfo[] ci = t.GetConstructors();

            Console.WriteLine("Availavle constructors: ");
            foreach (ConstructorInfo c in ci)
            {
                Console.Write("  " + t.Name + "(");

                ParameterInfo[] pi = c.GetParameters();

                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length)
                        Console.Write(", ");
                }

                Console.WriteLine(")");
            }
            Console.WriteLine();

            int x;

            for (x = 0; x < ci.Length; x++)
            {
                ParameterInfo[] pi = ci[x].GetParameters();
                if (pi.Length == 2)
                    break;
            }

            if (x == ci.Length)
            {
                Console.WriteLine("No matching constructor found");
                return;
            }
            else
                Console.WriteLine("Two-parameter constructor found.\n");

            object[] consargs = new object[2];
            consargs[0] = 10;
            consargs[1] = 20;
            object reflectOb = ci[x].Invoke(consargs);

            Console.WriteLine("\nInvoking methods on reflectOb.");
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
                else
                {
                    if (m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(double))
                    {
                        object[] args = new object[2];
                        args[0] = 1.12;
                        args[1] = 23.4;
                        m.Invoke(reflectOb, args);
                    }
                    else
                    {
                        if (m.Name.Equals("Sum", StringComparison.Ordinal))
                        {
                            val = (int)m.Invoke(reflectOb, null);
                            Console.WriteLine("Sum is " + val);
                        }
                        else
                        {
                            if (m.Name.Equals("IsBetween", StringComparison.Ordinal))
                            {
                                object[] args = new object[1];
                                args[0] = 14;
                                if ((bool)m.Invoke(reflectOb, args))
                                {
                                    Console.WriteLine("14 is between x and y");
                                }
                            }
                            else
                            {
                                if (m.Name.Equals("Show"))
                                {
                                    m.Invoke(reflectOb, null);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
