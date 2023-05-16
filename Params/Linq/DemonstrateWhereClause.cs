using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DemonstrateWhereClause
    {
        public static void DemonstrateWhereClauseMain()
        {
            Console.WriteLine("\n=== Where Clauses ===");

            string[] strs = { ".com", ".net", "hsNameA.com", "hsNameB.net",
                                "test", ".network", "hsNameC.net", "hsNameD.com" };

            var netAddrs = from addr in strs
                           where addr.Length > 4 && addr.EndsWith(".net", StringComparison.Ordinal)
                           select addr;

            foreach (var item in netAddrs)
                Console.WriteLine(item);
        }
    }
}
