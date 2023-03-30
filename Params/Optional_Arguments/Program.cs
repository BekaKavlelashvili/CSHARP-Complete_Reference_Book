class UseOptArgs
{
    static void Display(string str, int start = 0, int stop = -1)
    {
        if (stop < 0)
        {
            stop = str.Length;
        }

        if (stop > str.Length | start > stop | start < 0)
            return;

        for (int i = start; i < stop; i++)
            Console.Write(str[i]);

        Console.WriteLine();
    }

    static void Main()
    {
        Display("This is a test");
        Display("This is a test", 10);
        Display("This is a test", 5, 12);
    }
}