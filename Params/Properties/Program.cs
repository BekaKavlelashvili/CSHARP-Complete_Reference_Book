class SimpProp
{
    int prop;

    public SimpProp() { prop = 0; }

    public int MyProp
    {
        get
        {
            return prop;
        }
        set
        {
            if (value >= 0) prop = value;
        }
    }
}

class PropDemo
{
    static void Main()
    {
        SimpProp ob = new SimpProp();

        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);

        ob.MyProp = 100;
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);

        Console.WriteLine("Attempting to assign -10 to ob.MyProp");
        ob.MyProp = -10;
        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);
    }
}