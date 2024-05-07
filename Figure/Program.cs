using Core;
using Domain;

namespace Figure;

public class Program
{
    static void Main(string[] args)
    {
        IFigure figure = new Circle(10);
        Console.WriteLine(figure.GetArea());
        figure = new Triangle(9, 12, 15);
        Console.WriteLine(figure.GetArea());
    }
}
