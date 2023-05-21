using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Item1
    {
        public string Name { get; set; }
        public int ItemNumber { get; set; }

        public Item1(string name, int itemNumber)
        {
            Name = name;
            ItemNumber = itemNumber;
        }
    }

    class InStockStatus1
    {
        public int ItemNumber { get; set; }
        public bool InStock { get; set; }

        public InStockStatus1(int itemNumber, bool inStock)
        {
            ItemNumber = itemNumber;
            InStock = inStock;
        }
    }

    public class DemonstrateAnonymousType
    {
        public static void DemonstrateAnonymousTypeMain()
        {
            Console.WriteLine("\n=== Anonymous Types ====");

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
                              select new
                              {
                                  Name = item.Name,
                                  InStock = entry.InStock
                              };

            //PROJECTION INITIALIZER - This name automatically becomes the name of the property.

            //var inStockList = from item in items
            //                  join entry in statusList
            //                  on item.ItemNumber equals entry.ItemNumber
            //                  select new
            //                  {
            //                     item.Name,
            //                     entry.InStock
            //                  };

            Console.WriteLine("Item\tAvailable\n");

            foreach (var item in inStockList)
            {
                Console.WriteLine("{0}\t{1}", item.Name, item.InStock);
            }
        }
    }
}
