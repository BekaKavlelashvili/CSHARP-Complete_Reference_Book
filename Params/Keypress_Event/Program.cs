class KeyEventArgs : EventArgs
{
    public char ch;
}

class KeyEvent
{
    public event EventHandler<KeyEventArgs> KeyPress;

    public void OnKeyPress(char key)
    {
        KeyEventArgs k = new KeyEventArgs();

        if (k != null)
        {
            k.ch = key;
            KeyPress(this, k);
        }
    }
}

class KeyEventDemo
{
    static void Main()
    {
        KeyEvent kevt = new KeyEvent();
        ConsoleKeyInfo key;
        int count = 0;

        kevt.KeyPress += (sender, e) => Console.WriteLine(" Received keystroke " + e.ch);

        kevt.KeyPress += (sender, e) => count++;

        Console.WriteLine("Enter some characters." + "Enter a period to stop.");

        do
        {
            key = Console.ReadKey();
            kevt.OnKeyPress(key.KeyChar);
        } while (key.KeyChar != '.');

        Console.WriteLine(count + " keys pressed.");
    }
}