using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ExpressionTree
    {
        public static void ExpressionTreeMain()
        {
            Console.WriteLine("\n=== Expression Tree ===");

            Expression<Func<int, int, bool>> IsFactorExp = (n, d) => (d != 0) ? (n % d == 0) : false;

            Func<int, int, bool> IsFactor = IsFactorExp.Compile();

            if(IsFactor(10, 5))
                Console.WriteLine("5 is a factor of 10.");

            if(!IsFactor(10, 7))
                Console.WriteLine("7 is not a factor of 10.");

            Console.WriteLine();
        }
    }
}
