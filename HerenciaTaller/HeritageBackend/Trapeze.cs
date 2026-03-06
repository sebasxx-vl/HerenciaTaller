using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageBackend;
public class Trapeze : Triangle
{
    // Fields
    private float _d;

    // Constructors
    public Trapeze(float a, float b, float c, float h, float d) : base(a, b, c, h)
    {
        Name = "Trapeze";
        D = d;
    }

    // Properties
    public float D
    {
        get { return _d; }
        set { _d = ValidateD(value); }
    }

    // Methods
    public override float GetArea()
    {
        return ((A + B) * H) / 2;
    }

    public override float GetPerimeter()
    {
        return A + B + C + _d;
    }

    private float ValidateD(float d)
    {
        if (d <= 0)
            throw new ArgumentException("El lado D debe ser mayor que 0");
        return d;
    }
}
