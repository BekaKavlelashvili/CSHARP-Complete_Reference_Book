class AvgNums
{
    static void Main()
    {
        string str;
        int n;
        double sum = 0.0;
        double avg, t;

        Console.WriteLine("How many numbers will you enter: ");
        str = Console.ReadLine();

        try
        {
            n = Int32.Parse(str);
        }
        catch (FormatException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }
        catch (OverflowException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }

        Console.WriteLine("Enter " + n + " values.");
        for (int i = 0; i < n; i++)
        {
            Console.Write(": ");
            str = Console.ReadLine();

            try
            {
                t = Double.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                t = 0.0;
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc.Message);
                t = 0;
            }
            sum += t;
        }

        avg = sum / n;
        Console.WriteLine("Avg is: " + avg);
    }
}