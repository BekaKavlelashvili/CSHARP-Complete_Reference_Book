#define EXPERIMENTAL
#define TRIAL

static class IfEndIf
{
    public static void Test()
    {

#if EXPERIMENTAL
        Console.WriteLine("Compiled for experimental version.");
#endif

#if EXPERIMENTAL && TRIAL
        Console.WriteLine("Testing experimental and trial versions.");
#endif

        Console.WriteLine("This is in all versions");
    }
}