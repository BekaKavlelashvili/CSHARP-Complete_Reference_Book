class Redirect
{
    static void Main()
    {
        StreamWriter log_out = null;

		try
		{
			log_out = new StreamWriter(@"C:\\Users\\NEUTRONS\\source\\repos\\C#_Complete_Reference\\CSHARP-Complete_Reference_Book\\Params\\Read_From_File\\TextFile1.txt");
			Console.SetOut(log_out);
			Console.WriteLine("This is the start of the log file.");

			for (int i = 0; i < 10; i++)
				Console.WriteLine(i);

			Console.WriteLine("This is the end of the log file.");
		}
		catch (IOException exc)
		{
            Console.WriteLine("I/O error:\n" + exc.Message);
		}
		finally
		{
			if(log_out != null)
				log_out.Close();
		}
    }
}