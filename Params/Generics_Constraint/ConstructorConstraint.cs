
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Constraint
{
    class MyClass
    {
        public MyClass()
        {

        }
    }

    class TestClass<T> where T : new()
    {
        T obj;

        public TestClass()
        {
            obj = new T();
        }
    }

    public static class ConstructorConstraint
    {
        public static void ConstructorConstraintMain()
        {
            Console.WriteLine("\n=== Constructor Constraint ===");
            TestClass<MyClass> test = new TestClass<MyClass>();
        }
    }
}
