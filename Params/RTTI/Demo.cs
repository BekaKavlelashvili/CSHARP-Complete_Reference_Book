using System.Reflection.Metadata.Ecma335;

internal static class Demo
{
    public static void UseIs()
    {
        A a = new A();
        B b = new B();

        Console.WriteLine("=== Using Is ===");
        if (a is A)
            Console.WriteLine("a is an A");
        if (b is A)
            Console.WriteLine("b is an A becouse it is derived from A");
        if (a is B)
            Console.WriteLine("This won't display -- a not derived from B");
        if (b is B)
            Console.WriteLine("b is a B");
        if (a is object)
            Console.WriteLine("a is an object");
    }

    public static void UseAs()
    {
        A a = new A();
        B b = new B();

        Console.WriteLine("\n=== Using As ===");

        b = a as B;

        if (b == null)
            Console.WriteLine("The cast in b = (B) a is NOT allowed.");
        else
            Console.WriteLine("The cast in b = (B) a is allowed");
    }

    public static void UseTypeof()
    {
        Console.WriteLine("\n=== Using typeof ===");

        Type t = typeof(StreamReader);

        Console.WriteLine(t.FullName);

        if(t.IsClass)
            Console.WriteLine("t is class");
        if(t.IsAbstract)
            Console.WriteLine("t is abstract");
        else
            Console.WriteLine("t is concrete");
    }
}

class A { }

class B : A { }
