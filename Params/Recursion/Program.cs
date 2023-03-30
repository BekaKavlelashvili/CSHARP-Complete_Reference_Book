class Factorial
{
    public int FactR(int n)
    {
        int result;

        if (n == 1) return 1;
        result = FactR(n - 1) * n;

        return result;
    }

    public int FactI(int n)
    {
        int t, result;
        result = 1;

        for (t = 1; t <= n; t++) result *= t;

        return result;
    }
}

class Recursion
{
    static void Main()
    {
        Factorial f = new Factorial();

        Console.WriteLine("Factorials using recursive methods");
        Console.WriteLine("Factorial of 3 is: " + f.FactR(3));
        Console.WriteLine("Factorial of 4 is: " + f.FactR(4));
        Console.WriteLine("Factorial of 5 is: " + f.FactR(5));
        Console.WriteLine();

        Console.WriteLine("Factorials using iterative methods");
        Console.WriteLine("Factorial of 3 is: " + f.FactI(3));
        Console.WriteLine("Factorial of 4 is: " + f.FactI(4));
        Console.WriteLine("Factorial of 5 is: " + f.FactI(5));

    }
}