using System.Diagnostics;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void GenerateCircleTest()
    {
        var FigureCircle = new Figures.Class1().GenerateCircle();
        Debug.WriteLine("Test circle");
        Xunit.Assert.Equal("Circle", FigureCircle);

    }
    [Fact]
    public void Test2()
    {
        List<IShape> shapes= new List<IShape>();
        shapes.Add(new CircleFigure());
        shapes.Add(new TriangleFigure());
        Xunit.Assert.True(shapes.First() is CircleFigure);
        Xunit.Assert.False(shapes.Last() is CircleFigure);
    }
}