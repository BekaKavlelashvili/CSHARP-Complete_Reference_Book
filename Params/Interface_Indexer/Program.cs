public interface ISeries
{
    int Next { get; set; }

    int this[int index] { get; }
}

class ByTwos : ISeries
{
    int val;

    public ByTwos()
    {
        val = 0;
    }

    public int Next
    {
        get
        {
            val += 2;
            return val;
        }
        set
        {
            val = value;
        }
    }

    public int this[int index]
    {
        get
        {
            val = 0;
            for (int i = 0; i < index; i++)
            {
                val += 2;
            }
            return val;
        }
    }
}

class SeriesDemo
{
    static void Main()
    {
        ByTwos ob = new ByTwos();

        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " + ob.Next);

        Console.WriteLine("\nStarting at 21");
        ob.Next = 21;
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " + ob.Next);

        Console.WriteLine("\nResetting to 0");
        ob.Next = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Next value is " + ob[i]);
        }
    }
}