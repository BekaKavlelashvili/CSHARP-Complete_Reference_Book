using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Namespace
{
    class Pythagorean
    {
        public static void PythagoreanMain()
        {
            Console.WriteLine("\n=== Pythagorean Theorem ===");

            double s1;
            double s2;
            double hypot;
            string str;

            Console.WriteLine("Enter length of first side: ");
            str = Console.ReadLine();
            s1 = double.Parse(str);

            Console.WriteLine("Enter length of second side: ");
            str = Console.ReadLine();
            s2 = double.Parse(str);

            hypot = Math.Sqrt(s1 * s1 + s2 * s2);

            Console.WriteLine("Hypotenuse is " +  hypot);
        }
    }

    class UsePow
    {
        public static void UsePowMain()
        {
            Console.WriteLine("\n=== Using of Pow ===");
            decimal initInvest; //initial value
            decimal futVal; //future value
            double numYears; //number of years
            double intRate; //annual rate of return as a decimal
            string str;

            Console.Write("Enter future value: ");
            str = Console.ReadLine();

            try
            {
                futVal = decimal.Parse(str);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.Write("Enter interest rate (such as 0.085): ");
            str = Console.ReadLine();
            try
            {
                intRate = double.Parse(str);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.Write("Enter number of years: ");
            str = Console.ReadLine();
            try
            {
                numYears = double.Parse(str);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            initInvest = futVal / (decimal)Math.Pow(intRate + 1.0, numYears);

            Console.WriteLine("Initial investment required: {0:C}", initInvest);
        }
    }

    public class UsingMathClass
    {
        public static void UsingMathClassMain()
        {
            Console.WriteLine("\n==== Using Math Class ====");
            Pythagorean.PythagoreanMain();
            UsePow.UsePowMain();
        }
    }
}
