delegate void MyEventHandler();

class MyEvent
{
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent();
    }
}

class EventDemo
{
    static  void Handler()
    {
        Console.WriteLine("Event occurred");
    }

    static void Main()
    {
        MyEvent evt = new MyEvent();

        evt.SomeEvent += Handler;
        evt.OnSomeEvent();
    }
}