using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageBackend;
public class Square : GeometricFigure
{
    // Fields
    private float _a;

    // Constructors
    public Square(float A)
    {
        Name = "Square";
        A = _a;
    }

    // Properties
    public float A 
    {
        get { return _a; }
        set { _a = ValidateA(value); } 
    }

    // Methods
    public override float GetArea()
    {
        return _a * _a;
    }

    public override float GetPerimeter()
    {
        return 4 * _a;
    }

    private float ValidateA(float A)
    {
        if (A <= 0)
            throw new ArgumentException("El radio debe ser mayor que 0");
        return A;
    }
}
