using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Constraint
{
    class MyTestClass
    {
    }

    class MyTest<T> where T : class
    {
        T obj;

        public MyTest()
        {
            obj = null;
        }

        public void Message()
        {
            Console.WriteLine("Hello from Reference Constraint");
        }
    } 

    public static class ReferenceTypeConstraint
    {
        public static void ReferenceTypeConstraintMain()
        {
            Console.WriteLine("\n=== Reference Constraint ===");

            MyTest<MyClass> myTest = new MyTest<MyClass>();
            myTest.Message();
            //it is in error becaouse MyTest class is using reference constraint
            //MyTest<int> myTest1 = new MyTest<int>();
        }
    }
}
