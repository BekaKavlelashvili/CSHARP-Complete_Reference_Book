class FailSoftArray
{
    int[] a;
    public int Length;
    public bool ErrFlag;

    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }

    public int this[int index]
    {
        get
        {
            if (ok(index))
            {
                ErrFlag = false;
                return a[index];
            }
            else
            {
                ErrFlag = true;
                return 0;
            }
        }
        set
        {
            if (ok(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else ErrFlag = true;
        }
    }

    public int this[double idx]
    {
        get
        {
            int index;
            if ((idx - (int)idx) < 0.5) index = (int)idx;
            else index = (int)idx + 1;

            if (ok(index))
            {
                ErrFlag = false;
                return a[index];
            }
            else
            {
                ErrFlag = true;
                return 0;
            }
        }
        set
        {
            int index;
            if ((idx - (int)idx) < 0.5) index = (int)idx;
            else index = (int)idx + 1;

            if (ok(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else ErrFlag = true;
        }
    }

    private bool ok(int index)
    {
        if (index >= 0 & index < Length) return true;

        return false;
    }
}

class FSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);

        for (int i = 0; i < fs.Length; i++)
        {
            fs[i] = i;
        }

        Console.WriteLine("fa[1]:" + fs[1]);
        Console.WriteLine("fa[2]:" + fs[2]);

        Console.WriteLine("fa[1.1]:" + fs[1.1]);
        Console.WriteLine("fa[1.6]:" + fs[1.6]);
    }
}
