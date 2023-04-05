class FailSoftArray2D
{
    int[,] a;
    int rows, cols;
    public int Length;
    public bool ErrFlag;

    public FailSoftArray2D(int r, int c)
    {
        rows = r;
        cols = c;
        a = new int[rows, cols];
        Length = rows * cols;
    }

    public int this[int index1, int index2]
    {
        get
        {
            if (ok(index1, index2))
            {
                ErrFlag = false;
                return a[index1, index2];
            }
            else
            {
                ErrFlag = true;
                return 0;
            }
        }
        set
        {
            if (ok(index1, index2))
            {
                a[index1, index2] = value;
                ErrFlag = false;
            }
            else ErrFlag = true;
        }
    }

    bool ok(int index1, int index2)
    {
        if (index1 >= 0 & index1 < rows & index2 >= 0 & index2 < cols)
            return true;

        return false;

    }
}

class TwoDIndexerDemo
{
    static void Main()
    {
        FailSoftArray2D fs = new FailSoftArray2D(3, 5);
        int x;

        Console.WriteLine("Fail quietly.");
        for (int i = 0; i < 6; i++)
            fs[i, i] = 10 * i;

        for (int i = 0; i < 6; i++)
        {
            x = fs[i, i];
            if (x != -1) Console.Write(x + " ");
        }

        Console.WriteLine();

        Console.WriteLine("\nFail with error reports: ");
        for (int i = 0; i < 6; i++)
        {
            fs[i, i] = i * 10;
            if (fs.ErrFlag) Console.WriteLine("fs[" + i + "," + i + "] out-of-bounds");
        }

        for (int i = 0; i < 6; i++)
        {
            x = fs[i, i];
            if (!fs.ErrFlag) Console.Write(x + " ");
            else Console.WriteLine("fs[" + i + "," + i + "] out-of-bounds");
        }
    }
}