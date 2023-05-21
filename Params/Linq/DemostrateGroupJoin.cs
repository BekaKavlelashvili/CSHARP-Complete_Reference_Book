using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Transport
    {
        public string Name { get; set; }
        public string How { get; set; }

        public Transport(string name, string how)
        {
            Name = name;
            How = how;
        }
    }

    public class DemostrateGroupJoin
    {
        public static void DemostrateGroupJoinMain()
        {
            Console.WriteLine("\n=== Group Join ===");

            string[] travelTypes =
            {
                "Air",
                "Sea",
                "Land"
            };

            Transport[] transports = {
                 new Transport("Bicycle", "Land"),
                 new Transport("Balloon", "Air"),
                 new Transport("Boat", "Sea"),
                 new Transport("Jet", "Air"),
                 new Transport("Canoe", "Sea"),
                 new Transport("Biplane", "Air"),
                 new Transport("Car", "Land"),
                 new Transport("Cargo Ship", "Sea"),
                 new Transport("Train", "Land")
            };

            var byHow = from how in travelTypes
                        join trans in transports
                        on how equals trans.How
                        into lst
                        select new
                        {
                            How = how,
                            Tlist = lst
                        };

            foreach (var t in byHow)
            {
                Console.WriteLine("{0} transportation includes: ", t.How);

                foreach (var item in t.Tlist)
                    Console.WriteLine(" " + item.Name);
            }

            Console.WriteLine();
        }
    }
}
