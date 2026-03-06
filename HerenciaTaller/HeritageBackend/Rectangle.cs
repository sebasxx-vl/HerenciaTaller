using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HeritageBackend;
public class Rectangle : Square
{
    // Fields
    private float _b;

    // Constructors
    public Rectangle (float _b) : base(1)
    {
        Name = "Rectangle";
        B = _b;
    }

    // Properties
    public float B 
    {
        get { return _b; }
        set { _b = ValidateB(value); } 
    }

    //Methods
    public override float GetArea()
    {
        return A * _b;
    }

    public override float GetPerimeter()
    {
        return 2 * (A + _b);
    }

    private float ValidateB(float B)
    {
        if (B <= 0)
        {
            throw new ArgumentException("El lado B debe ser mayor que 0");
        }
        return B;
    }
}
