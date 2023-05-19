using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DemonstrateIntoWithGroup
    {
        public static void DemonstrateIntoWithGroupMain()
        {
            Console.WriteLine("\n=== Into With Group By ===");

            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                 "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                 "hsNameG.tv", "hsNameH.net", "hsNameI.tv" };

            var webAddrs = from website in websites
                           where website.LastIndexOf('.') != -1
                           group website by website.Substring(website.LastIndexOf("."))
                            into ws
                           where ws.Count() > 2
                           select ws;

            Console.WriteLine("Top-level domains with more than 2 members.\n");

            foreach (var sites in webAddrs)
            {
                Console.WriteLine("Contents of " + sites.Key + " domain:");
                foreach (var site in sites)
                {
                    Console.WriteLine(" " + site);
                }
                Console.WriteLine();
            }
        }
    }
}
