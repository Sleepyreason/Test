using System.Diagnostics;
using Xunit;
namespace TestProject1;
public class ShapeAreaCalculatorTests
{
    [Fact]
    public void CalculateArea_ShouldReturnCorrectAreaForCircle()
    {
        IShape circle = new CircleFigure(5);
        double area = ShapeAreaCalculator.CalculateArea(circle);
        Assert.Equal(Math.PI * 25, area, 5);
    }

    [Fact]
    public void CalculateArea_ShouldReturnCorrectAreaForTriangle()
    {
        IShape triangle = new TriangleFigure(3, 4, 5);
        double area = ShapeAreaCalculator.CalculateArea(triangle);
        Assert.Equal(6, area, 5);
    }
}