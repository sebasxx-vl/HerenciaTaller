using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageBackend;

public class Rhombus : Square
{
    // Fields
    private float _d1;
    private float _d2;

    // Constructors
    public Rhombus(float d1, float d2) : base(1)
    {
        Name = "Rhombus";
        D1 = d1;
        D2 = d2;
    }

    // Properties
    public float D1
    {
        get { return _d1; }
        set { _d1 = ValidateD1(value); }
    }

    public float D2
    {
        get { return _d2; }
        set { _d2 = ValidateD2(value); }
    }

    // Methods
    public override float GetArea()
    {
        return (_d1 * _d2) / 2;
    }

    public override float GetPerimeter()
    {
        return 4 * MathF.Sqrt(MathF.Pow(_d1 / 2, 2) + MathF.Pow(_d2 / 2, 2));
    }

    private float ValidateD1(float d1)
    {
        if (d1 <= 0)
            throw new ArgumentException("La diagonal 1 debe ser mayor que 0");
        return d1;
    }
    private float ValidateD2(float d2)
    {
        if (d2 <= 0)
            throw new ArgumentException("La diagonal 2 debe ser mayor que 0");
        return d2;
    }
}

