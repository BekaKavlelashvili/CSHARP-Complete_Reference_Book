class Cipher
{
    static int Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: encode/decode word1 [word2....wordN]");
            return 1;
        }

        if (args[0] != "encode" & args[0] != "decode")
        {
            Console.WriteLine("First arg must be encode or decode");
            return 1;
        }

        for (int i = 1; i < args.Length; i++)
        {
            for (int j = 0; j < args[i].Length; j++)
            {
                if (args[0] == "encode")
                {
                    Console.WriteLine((char)(args[i][j] + 1));
                }
                else
                {
                    Console.WriteLine((char)(args[i][j] - 1));
                }
            }
            Console.Write(" ");
        }
        Console.WriteLine();
        return 0;
    }
}