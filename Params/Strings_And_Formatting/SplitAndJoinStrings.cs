using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class SplitAndJoinStrings
    {
        public static void SplitAndJoinStringsMain()
        {
            Console.WriteLine("\n=== Split and Join ===");

            string str = "One if by land, two if by sea.";
            char[] seps = { ' ', '.', ',' };

            string[] parts = str.Split(seps);
            Console.WriteLine("Pieces from split: ");
            for (int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);

            string whole = String.Join(" | ", parts);
            Console.WriteLine("result of join: ");
            Console.WriteLine(whole);
        }
    }
}
