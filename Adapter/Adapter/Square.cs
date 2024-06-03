public class Square
{
    public double SideLength { get; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public double Area()
    {
        return SideLength * SideLength;
    }
}
