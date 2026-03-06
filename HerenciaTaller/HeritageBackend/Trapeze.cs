namespace HeritageBackend;

public class Trapeze : Triangle
{
    // Fields
    private double _d;

    // Constructors
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        Name = name;
        D = d;
    }

    // Properties
    public double D
    {
        get { return _d; }
        set { _d = ValidateD(value); }
    }

    // Methods
    public override double GetArea()
    {
        return ((A + B) * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + _d;
    }

    private double ValidateD(double d)
    {
        if (d <= 0)
            throw new ArgumentException("El lado D debe ser mayor que 0");
        return d;
    }
}