class TwoDShape
{
    double pri_width;
    double pri_height;

    public double Width
    {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }

    public double Height
    {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }

    public void ShowDim()
    {
        Console.WriteLine("Width and height are " + Width + " and " + Height);
    }
}

class Triangle : TwoDShape
{
    string Style;

    public Triangle(string s, double w, double h)
    {
        Width = w;
        Height = h;
        Style = s;
    }

    public double Area()
    {
        return Width * Height / 2;
    }

    public void ShowStyle()
    {
        Console.WriteLine("Triangle is " + Style);
    }
}

class Shapes3
{
    static void Main()
    {
        Triangle t1 = new Triangle("isosceles", 4.0, 4.0);
        Triangle t2 = new Triangle("right", 8.0, 12.0);

        Console.WriteLine("Info for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Info for t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());
    }
}