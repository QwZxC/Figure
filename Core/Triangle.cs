using Domain;

namespace Core;

public class Triangle : IFigure
{
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double Perimeter
    {
        get { return A + B + C; }
    }

    public double GetArea()
    {
        IsTriangleRectangular();
        double halfPerimeter = Perimeter / 2;
        return Math.Sqrt(halfPerimeter * 
                        (halfPerimeter-A) *
                        (halfPerimeter-B) *
                        (halfPerimeter-C));
    }

    private void IsTriangleRectangular()
    {
        if (Math.Pow(C, 2).Equals(Math.Pow(A, 2) + Math.Pow(B, 2)))
        {
            Console.WriteLine("Треугольник является прямоугольным");
        }
    }
}
