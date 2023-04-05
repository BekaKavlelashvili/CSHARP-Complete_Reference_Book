class PwrOfTwo
{
    public int this[int index]
    {
        get
        {
            if ((index >= 0) && (index < 16)) return pwr(index);
            else return -1;
        }
    }

    int pwr(int index)
    {
        int result = 1;

        for (int i = 0; i < index; i++)
            result *= 2;

        return result;
    }
}

class UsePwrOfTwo
{
    static void Main()
    {
        PwrOfTwo pwr = new PwrOfTwo();

        Console.WriteLine("First 8 powers of 2: ");
        for (int i = 0; i < 8; i++)
            Console.Write(pwr[i] + " ");

        Console.WriteLine();

        Console.Write("Here are some errors: ");
        Console.Write(pwr[-1] + " " + pwr[17]);

        Console.WriteLine();
    }
}