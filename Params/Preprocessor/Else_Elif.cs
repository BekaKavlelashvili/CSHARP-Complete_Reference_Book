#define RELEASE

internal static class Else_Elif
{
    public static void Test()
    {
#if EXPERIMENTAL
        Console.WriteLine("Compiled for experimental version.");
#elif RELEASE
        Console.WriteLine("Compiled for release.");
#else
        Console.WriteLine("Compiled for internal testing");
#endif

#if TRIAL && !RELEASE
 Console.Error.WriteLine("Trial version.");
#endif

        Console.WriteLine("This is in all versions.");
    }
}

