using System.Text.Json;

public interface ISeries
{
    int GetNext();

    void Reset();

    void SetStart(int x);
}

class ByTwos : ISeries
{
    int start;
    int val;

    public ByTwos()
    {
        start = 0;
        val = 0;
    }

    public int GetNext()
    {
        val += 2;
        return val;
    }

    public void Reset()
    {
        val = start;
    }

    public void SetStart(int x)
    {
        start = x;
        val = start;
    }
}

class Primes : ISeries
{
    int start;
    int val;

    public Primes()
    {
        start = 2;
        val = 2;
    }

    public int GetNext()
    {
        int i, j;
        bool isPrime;

        val++;
        for (i = val; i < 1000000; i++)
        {
            isPrime = true;
            for (j = 2; j <= i / j; j++)
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                val = i;
                break;
            }
        }

        return val;
    }

    public void Reset()
    {
        val = start;
    }

    public void SetStart(int x)
    {
        start = x;
        val = start;
    }
}

class SeriesDemo
{
    static void Main()
    {
        ByTwos twoOb = new ByTwos();
        Primes primeOb = new Primes();
        ISeries ob;

        for (int i = 0; i < 5; i++)
        {
            ob = twoOb;
            Console.WriteLine("Next ByTwos valye is " + ob.GetNext());

            ob = primeOb;
            Console.WriteLine("Next prime number is " + ob.GetNext());
        }
    }
}