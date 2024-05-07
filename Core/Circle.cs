using Domain;

namespace Core;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; set; }
    
    public double GetArea()
    {
        return Math.Pow(Radius,2) * Math.PI;
    }
}
