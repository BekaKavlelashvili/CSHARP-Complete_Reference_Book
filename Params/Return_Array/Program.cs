class Factor
{
    public int[] FindFactors(int num, out int numFactors)
    {
        int[] facts = new int[80];
        int i, j;

        for (i = 2, j = 0; i < num / 2 + 1; i++)
        {
            if ((num % i) == 0)
            {
                facts[j] = i;
                j++;
            }
        }

        numFactors = j;
        return facts;
    }
}

class FindFactors
{
    static void Main()
    {
        Factor f = new Factor();

        int numFactors;
        int[] factors;

        factors = f.FindFactors(1000, out numFactors);
        Console.WriteLine("Factors for 1000 are: ");
        for (int i = 0; i < numFactors; i++)
            Console.WriteLine(factors[i] + " ");

        Console.WriteLine();
    }
}