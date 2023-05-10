using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Constraint
{
    class A2 { }

    class B2 : A2 { }

    class C2<T, V> where V : T
    {
        public void Message()
        {
            Console.WriteLine("Hello from Two Type Parameters Relationship Constraint");
        }
    }

    public static class TwoTypeParamsRelationshipConstraint
    {
        public static void TwoTypeParamsRelationshipConstraintMain()
        {
            Console.WriteLine("\n=== Two Type Relationship Constraint ===");

            C2<A2, B2> x = new C2<A2, B2>();
            x.Message();

            //this will be error because A2 does not inherit B2
            //C2<B2, A2> y = new C2<B2, A2>();
        }
    }
}
