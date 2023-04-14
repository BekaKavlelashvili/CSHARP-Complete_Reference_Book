class ExcTest
{
    public static void GenException()
    {
        int[] nums = new int[4];

        Console.WriteLine("Before exception is generated");

        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
            Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
        }

        Console.WriteLine("This won't be displayed");
    }
}

class ExcDemo
{
    static void Main()
    {
        try
        {
            ExcTest.GenException();
        }
        catch (IndexOutOfRangeException)
        {

            Console.WriteLine("Index out-of-bounds");
        }

        Console.WriteLine("After catch block");
    }
}