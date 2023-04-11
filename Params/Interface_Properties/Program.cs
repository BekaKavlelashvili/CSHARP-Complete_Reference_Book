public interface ISeries
{
    int Next { get; set; }
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
}

class SeriesDemo
{
    static void Main()
    {
        ByTwos byTwos = new ByTwos();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Next value is " + byTwos.Next);
        }

        Console.WriteLine("\nStarting at 21");
        byTwos.Next = 21;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Next value is " + byTwos.Next);
        }
    }
}