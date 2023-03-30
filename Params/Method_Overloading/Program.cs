class Overload
{
    public void OvlDemo()
    {
        Console.WriteLine("No parameters");
    }

    public void OvlDemo(int a)
    {
        Console.WriteLine("One parameter: " + a);
    }

    public int OvlDemo(int a, int b)
    {
        Console.WriteLine("Two parameters: " + a + " " + b);
        return a + b;
    }

    public double OvlDemo(double a, double b)
    {
        Console.WriteLine("Two double parameters: " + a + " " + b);
        return a + b;
    }
}

class OverloadDemo
{
    static void Main()
    {
        Overload overload = new Overload();
        int resI;
        double resD;

        overload.OvlDemo();
        Console.WriteLine();

        overload.OvlDemo(2);
        Console.WriteLine();

        resI = overload.OvlDemo(4, 6);
        Console.WriteLine("Result of overload.OvlDemo(4, 6): " + resI);
        Console.WriteLine();

        resD = overload.OvlDemo(1.1, 2.32);
        Console.WriteLine("Result of overload.OvlDemo(1.1, 2.32): " + resD);
        Console.WriteLine();
    }
}