class StrRdrWrtDemo
{
    static void Main()
    {
        StringWriter strWrt = null;
        StringReader strRdr = null;

        try
        {
            strWrt = new StringWriter();

            for (int i = 0; i < 10; i++)
            {
                strWrt.WriteLine("This is i: " + i);
            }

            strRdr = new StringReader(strWrt.ToString());
            string str = strRdr.ReadLine();

            while (str != null)
            {
                str = strRdr.ReadLine();
                Console.WriteLine(str);
            }
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O error\n" + exc.Message);
        }
        finally
        {
            if(strWrt != null) strWrt.Close();
            if(strRdr!= null) strRdr.Close();
        }
    }
}