delegate void MyEventHandler();

class MyEvent
{
    MyEventHandler[] evnt = new MyEventHandler[3];

    public event MyEventHandler SomeEvent
    {
        add
        {
            int i;

            for (i = 0; i < 3; i++)
            {
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    break;
                }
            }
            if (i == 3)
                Console.WriteLine("Event list full.");
        }
        remove
        {
            int i;

            for (i = 0; i < 3; i++)
            {
                if (evnt[i] == value)
                {
                    evnt[i] = null;
                    break;
                }
            }
            if (i == 3)
                Console.WriteLine("Event handler not found.");
        }
    }

    public void OnSomeEvent()
    {
        for (int i = 0; i < 3; i++)
        {
            if (evnt[i] != null)
                evnt[i]();
        }
    }
}

class W
{
    public void WHandler()
    {
        Console.WriteLine("Event received by W object");
    }
}

class X
{
    public void XHandler()
    {
        Console.WriteLine("Event received by X object");
    }
}

class Y
{
    public void YHandler()
    {
        Console.WriteLine("Event received by Y  object");
    }
}

class Z
{
    public void ZHandler()
    {
        Console.WriteLine("Event received by Z object");
    }
}

class EventDemo
{
    static void Main()
    {
        MyEvent evt = new MyEvent();
        W wOb = new W();
        X xOb = new X();
        Y yOb = new Y();
        Z zOb = new Z();

        Console.WriteLine("Adding events.");
        evt.SomeEvent += wOb.WHandler;
        evt.SomeEvent += xOb.XHandler;
        evt.SomeEvent += yOb.YHandler;
        evt.SomeEvent += zOb.ZHandler;
        Console.WriteLine();

        evt.OnSomeEvent();
        Console.WriteLine();

        Console.WriteLine("Remove xOb.Xhandler.");
        evt.SomeEvent -= xOb.XHandler;
        evt.OnSomeEvent();

        Console.WriteLine();

        Console.WriteLine("Try to remove xOb.XHandler again.");
        evt.SomeEvent -= xOb.XHandler;
        evt.OnSomeEvent();

        Console.WriteLine();

        Console.WriteLine("Add zOb.ZHandler");
        evt.SomeEvent += zOb.ZHandler;
        evt.OnSomeEvent();
    }
}