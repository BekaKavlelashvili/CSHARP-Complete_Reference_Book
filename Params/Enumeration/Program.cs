class EnumDemo
{
    enum Apple
    {
        Jonathan,
        GoldenDel,
        RedDel,
        Winesap,
        Cortland,
        McIntosh
    }

    static void Main()
    {
        string[] color =
        {
            "Red",
            "Yellow",
            "Red",
            "Red",
            "Red",
            "Reddish Green",
        };

        Apple i;
        for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
        {
            Console.WriteLine(i + "has value of " + (int)i);
        }

        Console.WriteLine();

        for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
            Console.WriteLine("Color of " + i + " is " + color[(int)i]);
    }
}