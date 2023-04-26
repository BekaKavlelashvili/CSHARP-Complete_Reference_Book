delegate int CountIt(int end);

class VarCapture
{
    static CountIt Counter()
    {
        int sum = 0;

        int ctObj(int end)
        {
            for (int i = 0; i <= end; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            return sum;
        }
        return ctObj;
    }

    static void Main()
    {
        CountIt count = Counter();

        int result;

        result = count(3);
        Console.WriteLine("Summation of 3 is: " + result);
        Console.WriteLine();

        result = count(5);
        Console.WriteLine("Summation of 5 is: " + result);
    }
}