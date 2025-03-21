using System;

public abstract class Shape
{
    protected abstract void Draw();
    protected abstract int Surface();

    public void Print()
    {
        Console.WriteLine($"A {GetType().Name};\nSurface: {Surface()}");
        Draw();
        Console.WriteLine();
    }
}

public class Square : Shape
{
    int _squareSide;

    public Square(int side)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Side width must be positive.");
        }
        _squareSide = side;
    }

    protected override void Draw()
    {
        for (int i = 0; i < _squareSide; ++i)
        {
            for (int j = 0; j < _squareSide; ++j)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    protected override int Surface()
    {
        return _squareSide * _squareSide;
    }
}

public class Rectangle : Shape
{
    int _rectangleHeight;
    int _rectangleWidth;

    public Rectangle(int height, int width)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentException("Width and height must be positive.");
        }
        _rectangleWidth = width;
        _rectangleHeight = height;
    }

    protected override void Draw()
    {
        for (int i = 0; i < _rectangleHeight; ++i)
        {
            for (int j = 0; j < _rectangleWidth; ++j)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    protected override int Surface()
    {
        return _rectangleHeight * _rectangleWidth;
    }
}

class Program
{
    static void Main(string[] args) 
    {
        Shape[] shapes = new Shape[2];
        shapes[0] = new Square(4);
        shapes[1] = new Rectangle(4, 8);

        foreach (Shape sh in shapes)
        {
            sh.Print();
        }
    }
}