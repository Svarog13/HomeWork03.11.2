using System;

class Program
{
    static void Main(string[] args)
    {
        Figure[] figures = new Figure[]
        {
            new Rectangle(5, 10),
            new Circle(3),
            new RightTriangle(4, 7),
            new Trapezoid(6, 10, 8)
        };

        foreach (var figure in figures)
        {
            Console.WriteLine($"Area: {figure.CalculateArea()}");
            Console.WriteLine($"Info: {figure.GetInfo()}");
            Console.WriteLine();
        }
    }
}

abstract class Figure
{
    public abstract double CalculateArea();
    public abstract string GetInfo();
}

class Rectangle : Figure
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return width * height;
    }

    public override string GetInfo()
    {
        return $"Rectangle - Width: {width}, Height: {height}";
    }
}

class Circle : Figure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override string GetInfo()
    {
        return $"Circle - Radius: {radius}";
    }
}

class RightTriangle : Figure
{
    private double baseLength;
    private double height;

    public RightTriangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this. height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }

    public override string GetInfo()
    {
        return $"Right Triangle - Base Length: {baseLength}, Height: {height}";
    }
}

class Trapezoid : Figure
{
    private double upperBase;
    private double lowerBase;
    private double height;

    public Trapezoid(double upperBase, double lowerBase, double height)
    {
        this.upperBase = upperBase;
        this.lowerBase = lowerBase;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * (upperBase + lowerBase) * height;
    }

    public override string GetInfo()
    {
        return $"Trapezoid - Upper Base: {upperBase}, Lower Base: {lowerBase}, Height: {height}";
    }
}