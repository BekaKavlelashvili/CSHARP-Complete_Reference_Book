using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Constraint
{
    class TestClass<T, V> where T : class
                          where V : struct
    {
        T ob1;
        V ob2;

        public TestClass(T ob1, V ob2)
        {
            this.ob1 = ob1;
            this.ob2 = ob2;
        }

       public void Message()
        {
            Console.WriteLine("Hello from Multiple Constraint");
        }
    }

    public static class MultipleConstraints
    {
        public static void MultipleConstraintsMain()
        {
            Console.WriteLine("\n=== Multiple Constraint ===");
            TestClass<string, int> x = new TestClass<string, int>("test", 11);
            x.Message();

            //this will be in error because bool is not reference type
            //TestClass<bool, int> y = new TestClass<bool, int>(true, 2);
        }
    }
}
