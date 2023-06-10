using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Formatting
{
    public class DemonstrateStringComparison
    {

        static void DemonstrateCompare()
        {
            Console.WriteLine("\n=== Demonstrate Compare Method ===");

            string str1 = "alpha";
            string str2 = "Alpha";
            string str3 = "Beta";
            string str4 = "alpha";
            string str5 = "alpha, beta";

            int result;

            result = string.Compare(str1, str2, StringComparison.CurrentCulture);
            Console.Write("Using culture-sensitive comparison: ");
            if (result < 0)
                Console.WriteLine(str1 + " is less than " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " is more than " + str2);
            else
                Console.WriteLine(str1 + " equals " + str2);


            result = string.Compare(str1, str2, StringComparison.Ordinal);
            Console.Write("Using a ordinal comparison: ");
            if (result < 0)
                Console.WriteLine(str1 + " is less than " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " is more than " + str2);
            else
                Console.WriteLine(str1 + " equals " + str2);


            result = string.CompareOrdinal(str1, str2);
            Console.Write("Using a CompareOrdinal(): ");
            if (result < 0)
                Console.WriteLine(str1 + " is less than " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " is greater than " + str2);
            else
                Console.WriteLine(str1 + " equals " + str2);

            Console.WriteLine();

            if (str1 == str4) Console.WriteLine(str1 + " == " + str4);
            if (str1 != str3) Console.WriteLine(str1 + " != " + str3);
            if (str1 != str2) Console.WriteLine(str1 + " != " + str2);

            Console.WriteLine();

            if (string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Using Equals() with OrdinalIgnoreCase, " + str1 + " equals " + str2);

            Console.WriteLine();

            if (string.Compare(str2, 0, str5, 0, 3, StringComparison.CurrentCulture) > 0)
                Console.WriteLine("Using the current culture, the first " +
                    "3 characters of " + str2 +
                    "\nare greater than the first " +
                    "3 character of " + str5);
        }

        static void DemonstrateConcat()
        {
            Console.WriteLine("\n=== Demonstrate Concat Method ===");

            string result = string.Concat("This ", "is ", "a ", "test ", "of ", "the ", "String ", "class.");

            Console.WriteLine("result: " + result);
        }

        static void DemonstrateObjectFormOfConcat()
        {
            Console.WriteLine("\n=== Demonstrate the Object form of Concat ===");

            string result = String.Concat("The value is " + 19);
            Console.WriteLine("result: " + result);

            result = String.Concat("hello ", 88, " ", 20.0, " ", false, " ", 23.45M);
            Console.WriteLine("result: " + result);

            TestClassForConcat test = new TestClassForConcat();
            result = string.Concat(test, " current count is: ", TestClassForConcat.Count);

            Console.WriteLine("result: " + result);
        }

        public static void DemonstrateStringComparisonMain()
        {
            Console.WriteLine("\n=== Demonstrate String Comparisons ===");
            DemonstrateCompare();
            DemonstrateConcat();
            DemonstrateObjectFormOfConcat();
        }
    }

    class TestClassForConcat
    {
        public static int Count = 0;

        public TestClassForConcat()
        {
            Count++;
        }
    }
}
