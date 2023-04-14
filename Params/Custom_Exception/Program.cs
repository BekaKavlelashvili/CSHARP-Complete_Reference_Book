class RangeArrayException : Exception
{
    public RangeArrayException() : base()
    {

    }

    public RangeArrayException(string message) : base(message)
    {

    }

    public RangeArrayException(string message, Exception innerException) : base(message, innerException)
    {

    }

    protected RangeArrayException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
    {

    }

    public override string ToString()
    {
        return Message;
    }
}

class RangeArray
{
    int[] a;
    int lowerBound;
    int upperBound;

    public int Length { get; private set; }

    public RangeArray(int low, int high)
    {
        high++;
        if (high <= low)
        {
            throw new RangeArrayException("Low index not less than high.");
        }
        a = new int[high - low];
        Length = high - low;

        lowerBound = low;
        upperBound = --high;
    }

    public int this[int index]
    {
        get
        {
            if (ok(index))
            {
                return a[index - lowerBound];
            }
            else
            {
                throw new RangeArrayException("Range Error.");
            }
        }
        set
        {
            if (ok(index))
            {
                a[index - lowerBound] = value;
            }
            else
            {
                throw new RangeArrayException("Range Error.");
            }
        }
    }

    private bool ok(int index)
    {
        if (index >= lowerBound & index <= upperBound)
            return true;
        return false;
    }
}

class RangeArrayDemo
{
    static void Main()
    {
        try
        {
            RangeArray ra = new RangeArray(-5, 5);
            RangeArray ra2 = new RangeArray(1, 10);

            Console.WriteLine("Length of ra: " + ra.Length);

            for (int i = -5; i <= 5; i++)
            {
                ra[i] = i;
            }

            Console.WriteLine("Contents of ra: ");
            for (int i = -5; i <= 5; i++)
            {
                Console.Write(ra[i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Length of ra2: " + ra2.Length);

            for (int i = 1; i <= 10; i++)
            {
                ra2[i] = i;
            }

            Console.WriteLine("Contents of ra2: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(ra2[i] + " ");
            }
            Console.WriteLine("\n");
        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }

        Console.WriteLine("Now generate some range errors.");

        try
        {
            RangeArray ra3 = new RangeArray(100, -10);
        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }


        try
        {
            RangeArray ra3 = new RangeArray(-2, 2);

            for (int i = -2; i <= 2; i++)
            {
                ra3[i] = i;
            }

            Console.Write("Contents of ra3: ");
            for (int i = -2; i <= 10; i++)
            {
                Console.Write(ra3[i] + " ");
            }
        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }
    }
}