using System.Runtime.CompilerServices;

class MyEvent
{
    public event EventHandler SomeEvent;

    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent(this, EventArgs.Empty);
    }
}

class EventDemo
{
    static void Handler(object sender, EventArgs e)
    {
        Console.WriteLine("Event occurred");
        Console.WriteLine("Source is " + sender);
    }

    static void Main()
    {
        MyEvent evt = new MyEvent();
        evt.SomeEvent += Handler;

        evt.OnSomeEvent();
    }
}