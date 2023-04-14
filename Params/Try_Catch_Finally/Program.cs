class UseFinally
{
    public static void GenException(int what)
    {
        int t;
        int[] nums = new int[2];

        Console.WriteLine("Receiving " + what);
        try
        {
            switch (what)
            {
                case 0:
                    t = 10 / what;
                    break;
                case 1:
                    nums[4] = 4;
                    break;
                case 2:
                    return;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by zero");
            return;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("No matching element found");
        }
        finally
        {
            Console.WriteLine("Leaving try");
        }
    }
}

class FinallyDemo
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            UseFinally.GenException(i);
            Console.WriteLine();
        }
    }
}