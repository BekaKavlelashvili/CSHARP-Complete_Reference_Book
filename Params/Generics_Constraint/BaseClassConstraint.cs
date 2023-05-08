using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Constraint
{

    class A
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }

    class B : A { }

    class C { }

    class Test<T> where T : A
    {
        T ob;

        public Test(T ob)
        {
            this.ob = ob;
        }

        public void SayHello()
        {
            ob.Hello();
        }
    }

    public static class BaseClassConstraint
    {
        public static void BaseClassConstraintMain()
        {
            Console.WriteLine("=== Base Class Constraint ===");

            A a = new A();
            B b = new B();
            C c = new C();

            Console.Write("A class: ");
            Test<A> t1 = new Test<A>(a);
            t1.SayHello();

            Console.Write("B class: ");
            Test<B> t2 = new Test<B>(b);
            t2.SayHello();

            //C class is not a base class or derived class of A
            //Test<C> t3 = new Test<C>(c);
            //t3.SayHello();
        }
    }
}
