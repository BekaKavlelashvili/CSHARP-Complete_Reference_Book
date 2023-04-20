using Microsoft.VisualBasic;

class WriteFile
{
    static void Main(string[] args)
    {
        FileStream fout = null;

        try
        {
            fout = new FileStream("test.txt", FileMode.CreateNew);
            for (char i = 'A'; i <= 'Z'; i++)
            {
                fout.WriteByte((byte)i);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O Error: " + e.Message);
        }
        finally
        {
            if (fout != null)
                fout.Close();
        }
    }
}