using System;
public class ShapePrinter
{
    public void PrintArea(IShape shape)
    {
        Console.WriteLine("The area is: " + shape.GetArea());
    }
}