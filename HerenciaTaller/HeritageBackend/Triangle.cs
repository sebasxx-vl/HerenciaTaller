namespace HeritageBackend;

public class Triangle : Rectangle
{
    // Fields
    private double _c;
    private double _h;

    // Constructors
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        Name = name;
        C = c;
        H = h;
    }

    // Properties
    public double C
    {
        get { return _c; }
        set { _c = ValidateC(value); }
    }

    public double H
    {
        get { return _h; }
        set { _h = ValidateH(value); }
    }

    // Methods
    public override double GetArea()
    {
        return (B * _h) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + _c;
    }

    private double ValidateC(double c)
    {
        if (c <= 0)
            throw new ArgumentException("El lado C debe ser mayor que 0");
        return c;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("La altura debe ser mayor que 0");
        return h;
    }
}