using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Item
    {
        public string Name { get; set; }

        public int ItemNumber { get; set; }

        public Item(string name, int itemNumber)
        {
            Name = name;
            ItemNumber = itemNumber;
        }
    }

    class InStockStatus
    {
        public int ItemNumber { get; set; }

        public bool InStock { get; set; }

        public InStockStatus(int itemNumber, bool inStock)
        {
            ItemNumber = itemNumber;
            InStock = inStock;
        }
    }

    class Temp
    {
        public string Name { get; set; }

        public bool InStock { get; set; }


        public Temp(string name, bool inStock)
        {
            Name = name;
            InStock = inStock;
        }
    }

    public class DemostrateJoin
    {
        public static void DemostrateJoinMain()
        {
            Console.WriteLine("\n=== Join ===");

            Item[] items = {
                 new Item("Pliers", 1424),
                 new Item("Hammer", 7892),
                 new Item("Wrench", 8534),
                 new Item("Saw", 6411)
            };

            InStockStatus[] statusList = {
                 new InStockStatus(1424, true),
                 new InStockStatus(7892, false),
                 new InStockStatus(8534, true),
                 new InStockStatus(6411, true)
            };

            var inStockList = from item in items
                              join entry in statusList
                              on item.ItemNumber equals entry.ItemNumber
                              select new Temp(item.Name, entry.InStock);

            Console.WriteLine("Item\tAvailable\n");

            foreach (Temp t in inStockList)
                Console.WriteLine("{0}\t{1}", t.Name, t.InStock);

        }
    }
}
