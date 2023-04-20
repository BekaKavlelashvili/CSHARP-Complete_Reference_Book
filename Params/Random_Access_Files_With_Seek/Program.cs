class RandomAccessDemo
{
    static void Main()
    {
        FileStream f = null;
        char ch;

        try
        {
            f = new FileStream("random.dat", FileMode.Create);
            for (int i = 0; i < 26; i++)
                f.WriteByte((byte)('A' + i));

            f.Seek(0, SeekOrigin.Begin);
            ch = (char)f.ReadByte();
            Console.WriteLine("First value is " + ch);

            f.Seek(1, SeekOrigin.Begin);
            ch = (char)f.ReadByte();
            Console.WriteLine("Second value is " + ch);

            f.Seek(4, SeekOrigin.Begin);
            ch = (char)f.ReadByte();
            Console.WriteLine("Fifth value is " + ch);

            Console.WriteLine();

            Console.WriteLine("Here is every other value: ");
            for (int i = 0; i < 26; i++)
            {
                f.Seek(i, SeekOrigin.Begin);
                ch = (char)f.ReadByte();
                Console.Write(ch + " ");
            }
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O error \n" + exc.Message);
        }
        finally
        {
            if(f != null)
                f.Close();
        }
        Console.WriteLine();
    }
}