using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageBackend;

public class Triangle : Rectangle
{
    // Fields
    private float _c;
    private float _h;

    // Constructors
    public Triangle(float a, float b, float c, float h) : base(a, b)
    {
        Name = "Triangle";
        C = c;
        H = h;
    }

    // Properties
    public float C
    {
        get { return _c; }
        set { _c = ValidateC(value); }
    }

    public float H
    {
        get { return _h; }
        set { _h = ValidateH(value); }
    }

    // Methods
    public override float GetArea()
    {
        return (A * _h) / 2;
    }

    public override float GetPerimeter()
    {
        return A + B + _c;
    }

    private float ValidateC(float c)
    {
        if (c <= 0)
            throw new ArgumentException("El lado C debe ser mayor que 0");
        return c;
    }

    private float ValidateH(float h)
    {
        if (h <= 0)
            throw new ArgumentException("La altura debe ser mayor que 0");
        return h;
    }
}