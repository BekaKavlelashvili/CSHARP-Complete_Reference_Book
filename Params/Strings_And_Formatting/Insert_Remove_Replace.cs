using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class Insert_Remove_Replace
    {
        public static void Insert_Remove_ReplaceMain()
        {
            Console.WriteLine("\n=== Insert Remove And Replace Strings ===");

            string str = "This test";
            Console.WriteLine("Original string: " + str);

            str = str.Insert(5, "is a ");
            Console.WriteLine(str);

            str = str.Replace("is", "was");
            Console.WriteLine(str);

            str = str.Replace('a', 'X');
            Console.WriteLine(str);

            str = str.Remove(4, 5);
            Console.WriteLine(str);
        }
    }
}
