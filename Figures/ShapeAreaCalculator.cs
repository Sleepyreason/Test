using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Figures;

public class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
    
}
