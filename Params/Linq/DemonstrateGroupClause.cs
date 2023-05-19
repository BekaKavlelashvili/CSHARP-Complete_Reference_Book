using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DemonstrateGroupClause
    {
        public static void DemonstrateGroupClauseMain()
        {
            Console.WriteLine("\n=== Group By ===");

            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                     "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                     "hsNameG.tv", "hsNameH.net", "hsNameI.tv" };

            var webAddrs = from website in websites
                           where website.LastIndexOf('.') != -1
                           group website by website.Substring(website.LastIndexOf("."));

            foreach ( var sites in webAddrs)
            {
                Console.WriteLine("Websites grouped by " + sites.Key);
                foreach (var site in sites)
                {
                    Console.WriteLine(" " + site);
                }
                Console.WriteLine();
            }
        }
    }
}
