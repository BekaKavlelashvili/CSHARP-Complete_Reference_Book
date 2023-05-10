using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyClass { }

    class TestClass<T>
    {
        public T obj;

        public TestClass()
        {
            obj = default(T);
        }
    }

    public static class DefaultValueOfTypeParameter
    {
        public static void DefaultValueOfTypeParameterMain()
        {
            Console.WriteLine("\n=== Default value of type parameters");
            TestClass<MyClass> testClass = new TestClass<MyClass>();

            if(testClass.obj == null)
                Console.WriteLine("x.obj is null");

            TestClass<int> y = new TestClass<int>();
            if(y.obj == 0)
                Console.WriteLine("y.obj is 0");
        }
    }
}
