using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class CharPair
    {
        public char First { get; set; }

        public char Second { get; set; }

        public CharPair(char first, char second)
        {
            First = first;
            Second = second;
        }

    }

    public class DemonstrateNestedFrom
    {
        public static void DemonstrateNestedFromMain()
        {
            Console.WriteLine("\n=== Nested from clauses ===");

            char[] chrs = { 'A', 'B', 'C' };
            char[] chrs2 = { 'X', 'Y', 'Z' };

            var pairs = from c in chrs
                        from c2 in chrs2
                        select new CharPair(c, c2);

            Console.WriteLine("All combinations of ABC with XYZ: ");

            foreach (var p in pairs)
                Console.WriteLine("{0} {1}", p.First, p.Second);
        }
    }
}
