//key to disk
class KtoD
{
    static void Main()
    {
        string str;
        StreamWriter fstr_out = null;

        try
        {
            fstr_out = new StreamWriter("test.txt");
            Console.WriteLine("Enter text ('stop' to quit).");
            do
            {
                Console.WriteLine(": ");
                str = Console.ReadLine();
                if (str != "stop")
                {
                    str = str + "\r\n";
                    fstr_out.Write(str);
                }
            } while (str != "stop");
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O error:\n" + e.Message);
        }
        finally
        {
            if (fstr_out != null)
                fstr_out.Close();
        }
    }
}