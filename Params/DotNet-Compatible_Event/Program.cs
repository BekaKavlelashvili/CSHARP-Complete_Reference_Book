class MyEventArgs : EventArgs
{
    public int EventNum;
}

delegate void MyEventHandler(object sender, MyEventArgs e);

class MyEvent
{
    static int count = 0;
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        MyEventArgs arg = new MyEventArgs();

        if (SomeEvent != null)
        {
            arg.EventNum = count++;
            SomeEvent(this, arg);
        }
    }
}

class X
{
    public void Handler(object sender, MyEventArgs e)
    {
        Console.WriteLine("Event " + e.EventNum + " received by an X object");
        Console.WriteLine("Source is " + sender);
        Console.WriteLine();
    }
}

class Y
{
    public void Handler(object sender, MyEventArgs e)
    {
        Console.WriteLine("Event " + e.EventNum + " received by a Y object.");
        Console.WriteLine("Source is " + sender);
        Console.WriteLine();
    }
}

class EventDemo
{
   static void Main()
    {
        X ob1 = new X();
        Y ob2 = new Y();
        MyEvent evt = new MyEvent();

        evt.SomeEvent += ob1.Handler;
        evt.SomeEvent += ob2.Handler;

        evt.OnSomeEvent();
        evt.OnSomeEvent();
    }
}