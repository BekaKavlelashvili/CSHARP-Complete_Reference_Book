using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Constraint
{
    struct MyStruct { }

    class MyClass1 { }

    class MyClass2<T> where T : struct
    {
        T obj;
        public MyClass2(T x)
        {
            obj = x;
        } 
        
        public void Message()
        {
            Console.WriteLine("Hello from Value Type Constraint");
        }
    }

    public static class ValueTypeConstraint
    {
        public static void ValueTypeConstraintMain()
        {
            Console.WriteLine("\n=== Value Type Constraint");
            MyClass2<MyStruct> class2 = new MyClass2<MyStruct>(new MyStruct());
            class2.Message();
            MyClass2<int> y = new MyClass2<int>(10);

            //it is in error becaouse MyClass2 is using value type constraint
            //MyClass2<MyClass1> myClass = new MyClass2<MyClass1>(new MyClass1());
        }
    }
}
