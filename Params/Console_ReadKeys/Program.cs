using System.Security.Cryptography;

class ReadKeys
{
    static void Main()
    {
        ConsoleKeyInfo keyPress;

        Console.WriteLine("Enter keystrokes. Enter Q to stop.");

        do
        {
            keyPress = Console.ReadKey();

            Console.WriteLine(" Your key is: " + keyPress.KeyChar);

            if ((ConsoleModifiers.Alt & keyPress.Modifiers) != 0)
                Console.WriteLine("Alt key pressed.");
            if ((ConsoleModifiers.Control & keyPress.Modifiers) != 0)
                Console.WriteLine("Control key pressed.");
            if ((ConsoleModifiers.Shift & keyPress.Modifiers) != 0)
                Console.WriteLine("Shift key pressed.");
        } while (keyPress.KeyChar != 'Q');
    }
}