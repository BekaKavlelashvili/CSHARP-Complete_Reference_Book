using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DemostrateLetClause
    {
        public static void DemostrateLetClauseMain()
        {
            Console.WriteLine("\n=== Let Clause with OrderBy");

            string[] strs = { "alpha", "beta", "gamma" };

            var chrs = from str in strs
                       let chars = str.ToCharArray()
                       from chr in chars
                       orderby chr
                       select chr;

            Console.WriteLine("The individual characters in sorted order:");

            foreach (char ch in chrs)
                Console.Write(ch + " ");
        }
    }
}
