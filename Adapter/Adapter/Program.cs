namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5.0);
            IShape squareAdapter = new SquareAdapter(square);

            ShapePrinter printer = new ShapePrinter();
            printer.PrintArea(squareAdapter);
        }
    }
}
