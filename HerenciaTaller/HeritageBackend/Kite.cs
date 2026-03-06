using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageBackend;

public class Kite : Rhombus
{
    // Fields
    private float _b;

    // Constructors
    public Kite(float d1, float d2, float b) : base(d1, d2)
    {
        Name = "Kite";
        B = b;
    }

    // Properties
    public float B
    {
        get { return _b; }
        set { _b = ValidateB(value); }
    }

    // Methods
    public override float GetArea()
    {
        return D1 * D2 / 2;
    }

    public override float GetPerimeter()
    {
        return 2 * (D1 + B)/ 2;
    }

    private float ValidateB(float b)
    {
        if (b <= 0)
            throw new ArgumentException("La diagonal 2 debe ser mayor que 0");
        return b;
    }
}
