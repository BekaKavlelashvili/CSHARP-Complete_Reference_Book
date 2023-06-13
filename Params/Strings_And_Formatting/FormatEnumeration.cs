using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class FormatEnumeration
    {
        enum Direction
        {
            North,
            South,
            East,
            West
        }

        [Flags]
        enum Status
        {
            Ready = 0x1,
            OffLine = 0x2,
            Waiting = 0x4,
            TransmitOK = 0x8,
            RecieveOK = 0x10,
            OnLine = 0x20
        }

        public static void FormatEnumerationMain()
        {
            Console.WriteLine("\n=== Format Enumeration ===");

            Direction d = Direction.West;

            Console.WriteLine("{0:G}", d);
            Console.WriteLine("{0:F}", d);
            Console.WriteLine("{0:D}", d);
            Console.WriteLine("{0:X}", d);

            Status s = Status.Ready | Status.TransmitOK;

            Console.WriteLine("{0:G}", s);
            Console.WriteLine("{0:F}", s);
            Console.WriteLine("{0:D}", s);
            Console.WriteLine("{0:X}", s);
        }
    }

}
