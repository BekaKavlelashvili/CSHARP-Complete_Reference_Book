class MemStrDemo
{
    static void Main()
    {
        byte[] storage = new byte[255];

        MemoryStream memstr = new MemoryStream(storage);

        StreamWriter memwtr = new StreamWriter(memstr);
        StreamReader memrdr = new StreamReader(memstr);

        try
        {
            for (int i = 0; i < 10; i++)
                memwtr.WriteLine("byte [" + i + "]: " + i);

            memwtr.WriteLine(".");

            memwtr.Flush();

            Console.WriteLine("Reading from storage directly: ");

            foreach (char ch in storage)
            {
                if (ch == '.')
                    break;
                Console.Write(ch);
            }

            Console.WriteLine("\nReading through memrdr: ");

            memstr.Seek(0, SeekOrigin.Begin);

            string str = memrdr.ReadLine();
            while (str != null)
            {
                str = memrdr.ReadLine();
                if (str[0] == '.')
                    break;
                Console.WriteLine(str);
            }
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O error\n" + exc.Message);
        }
        finally
        {
            memwtr.Close();
            memrdr.Close();
        }
    }
}