public abstract class Shape
{

    public abstract void Draw();

}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Triangle");
    }
}

