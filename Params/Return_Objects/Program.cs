class Rect
{
    int Width;
    int Height;

    public Rect(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area()
    {
        return Width * Height;
    }

    public void Show()
    {
        Console.WriteLine(Width + " " + Height);
    }

    // return a rectangle that is a specified factor larger than the invoking rectangle
    public Rect Enlarge(int factor)
    {
        return new Rect(Width * factor, Height * factor);
    }
}


public class RectObj
{
    public static void Main()
    {
        Rect r1 = new Rect(4, 5);

        Console.WriteLine("Dimensions of r1: ");
        r1.Show();
        Console.WriteLine("Area of r1: " + r1.Area());

        Console.WriteLine();

        //Create a rectangle that is twice as big as r1
        Rect r2 = r1.Enlarge(2);
        Console.WriteLine("Dimensions of r2: ");
        r2.Show();
        Console.WriteLine("Area of r2: " + r2.Area());
    }
}