class ShowFile
{
    static void Main(string[] args)
    {
        int i;
        FileStream fin = null;

        //if (args.Length != 1)
        //{
        //    Console.WriteLine("Usage: ShowFile File");
        //    return;
        //}

        try
        {
            fin = new FileStream(@"C:\\Users\\NEUTRONS\\source\\repos\\C#_Complete_Reference\\CSHARP-Complete_Reference_Book\\Params\\Read_From_File\\TextFile1.txt", FileMode.Open);
            do
            {
                i = fin.ReadByte();
                if (i != -1)
                    Console.Write((char)i);
            } while (i != 1);
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O Error:\n" + exc.Message);
        }
        finally
        {
            if (fin != null)
                fin.Close();
        }
    }
}