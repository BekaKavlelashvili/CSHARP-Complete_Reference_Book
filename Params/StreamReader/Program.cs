//disk to screen
class DToS
{
    static void Main()
    {
        FileStream fin;
        string s;

        try
        {
            fin = new FileStream(@"C:\\Users\\NEUTRONS\\source\\repos\\C#_Complete_Reference\\CSHARP-Complete_Reference_Book\\Params\\Read_From_File\\TextFile1.txt", FileMode.Open);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error opening file:\n" + exc.Message);
            return;
        }

        StreamReader fstr_in = new StreamReader(fin);

        try
        {
            while ((s = fstr_in.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O error:\n" + exc.Message);
        }
        finally
        {
            fstr_in.Close();
        }
    }
}