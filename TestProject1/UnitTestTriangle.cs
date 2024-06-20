using System.Diagnostics;
using Xunit;
namespace TestProject1;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_ShouldReturnCorrectArea()
    {
        var triangle = new TriangleFigure(3, 4, 5);
        double area = triangle.CalculateArea();
        Assert.Equal(6, area, 5);
    }

    [Fact]
    public void IsRightAngled_ShouldReturnTrueForRightAngledTriangle()
    {
        var triangle = new TriangleFigure(3, 4, 5);
        bool isRightAngled = triangle.IsRightAngled();
        Assert.True(isRightAngled);
    }

    [Fact]
    public void IsRightAngled_ShouldReturnFalseForNonRightAngledTriangle()
    {
        var triangle = new TriangleFigure(3, 4, 6);
        bool isRightAngled = triangle.IsRightAngled();
        Assert.False(isRightAngled);
    }
}
