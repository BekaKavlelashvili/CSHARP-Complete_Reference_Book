using System.Text.Json.Serialization;

class CheckedBlocks
{
    static void Main()
    {
        byte a, b;
        byte result;

        a = 127;
        b = 127;

        try
        {
            unchecked
            {
                a = 127;
                b = 127;
                result = unchecked((byte)(a * b));
                Console.WriteLine("Unchecked result: " + result);

                a = 125;
                b = 5;
                result = unchecked((byte)(a * b));
                Console.WriteLine("Unchecked result: " + result);
            }

            checked
            {
                a = 2;
                b = 7;
                result = checked((byte)(a * b));
                Console.WriteLine("Checked result: " + result);

                a = 127;
                b = 127;
                result = checked((byte)(a * b));
                Console.WriteLine("Checked result: " + result);
            }
        }
        catch (OverflowException exc)
        {
            Console.WriteLine(exc);
        }
    }
}