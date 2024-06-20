namespace Figures;

public class CircleFigure : IShape
{
    public double Radius { get; }

    public CircleFigure(double radius)
    {
        Radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}