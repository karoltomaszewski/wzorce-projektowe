public class SquareAdapter : IShape
{
    private readonly Square _square;

    public SquareAdapter(Square square)
    {
        _square = square;
    }

    public double GetArea()
    {
        return _square.Area();
    }
}
