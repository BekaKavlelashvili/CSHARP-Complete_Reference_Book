using System.Security.Cryptography.X509Certificates;

class ThreeD
{
    int x, y, z; //3D coordinates

    public ThreeD() { x = y = z = 0; }

    public ThreeD(int i, int j, int k)
    {
        x = i; // 1
        y = j; // 2
        z = k; // 3
    }

    //Overload binary +
    public static ThreeD operator +(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();

        result.x = op1.x + op2.x; // 2
        result.y = op1.y + op2.y; // 4
        result.z = op1.z + op2.z; // 6

        return result; // x = 2, y = 4, z = 6
    }

    //Overload binary -
    public static ThreeD operator -(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();

        result.x = op1.x - op2.x; // 0
        result.y = op1.y - op2.y; // 0
        result.z = op1.z - op2.z; // 0

        return result; // x = 0, y = 0, z = 0
    }


    //Overload unary -
    public static ThreeD operator -(ThreeD op)
    {
        ThreeD result = new ThreeD();

        result.x = -op.x;
        result.y = -op.y;
        result.z = -op.z;

        return result;
    }

    //Overload unary ++
    public static ThreeD operator ++(ThreeD op)
    {
        ThreeD result = new ThreeD();

        result.x = op.x + 1;
        result.y = op.y + 1;
        result.z = op.z + 1;

        return result;
    }

    public void Show()
    {
        Console.WriteLine(x + "," + y + "," + z);
    }
}

class ThreeDDemo
{
    static void Main()
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c;

        //binary
        Console.Write("Here is a: ");
        a.Show();
        Console.WriteLine();
        Console.Write("Here is b: ");
        b.Show();
        Console.WriteLine();

        c = a + b;
        Console.Write("Result of a + b: ");
        c.Show();
        Console.WriteLine();

        c = a + b + c;
        Console.Write("Result of a + b + c: ");
        c.Show();
        Console.WriteLine();

        c = c - a;
        Console.Write("Result of c - a: ");
        c.Show();
        Console.WriteLine();

        c = c - b;
        Console.Write("Result of c - b: ");
        c.Show();
        Console.WriteLine();

        //unary
        Console.WriteLine("Unary");
        c = -a;
        Console.Write("Result of -a: ");
        c.Show();
        Console.WriteLine();

        c = a++;
        Console.WriteLine("Given c = a++");
        Console.Write("c is:");
        c.Show();
        Console.Write("a is: ");
        a.Show();

        a = new ThreeD(1, 2, 3);
        Console.Write("\nResetting a to ");
        a.Show();

        c = ++a;
        Console.WriteLine("\nGiven c = ++a");
        Console.Write("c is: ");
        c.Show();
        Console.Write("a is: ");
        a.Show();
    }
}