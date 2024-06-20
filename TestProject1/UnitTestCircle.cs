using System.Diagnostics;
using Xunit;
namespace TestProject1;

public class CircleTests
{
    [Fact]
    public void CalculateArea_ShouldReturnCorrectArea()
    { 
        var circle = new CircleFigure(5);
        double area = circle.CalculateArea();
        Assert.Equal(Math.PI * 25, area, 5);
    }
}

