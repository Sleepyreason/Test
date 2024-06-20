namespace Figures;

public class TriangleFigure : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public TriangleFigure(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    public double CalculateArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }
    public bool IsRightAngled()
    {
        double a2 = SideA * SideA;
        double b2 = SideB * SideB;
        double c2 = SideC * SideC;

    // Проверяем каждую комбинацию
    return Math.Abs(a2 + b2 - c2) < 1e-10 ||
           Math.Abs(a2 + c2 - b2) < 1e-10 ||
           Math.Abs(b2 + c2 - a2) < 1e-10;
    }
}
