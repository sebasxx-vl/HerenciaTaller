using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageBackend;
public class Parallelogram : Rectangle
{
    // Fields
    private float _h;

    // Constructors
    public Parallelogram(float a, float b, float h) : base(a, b)
    {
        Name = "Parallelogram";
        H = h;
    }

    // Properties
    public float H 
    {
        get {return _h; }
        set {_h = ValidateH(value); } 
    }

    // Methods
    public override float GetArea()
    {
        return B * _h;
    }

    public override float GetPerimeter()
    {
        return 2 * (A + B);
    }

    private float ValidateH(float h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("La altura debe ser mayor que 0");
        }
        return h;
    }
}
