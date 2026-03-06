namespace HeritageBackend;

public class Kite : Rhombus
{
    // Fields
    private double _b;

    // Constructors
    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        Name = name;
        B = b;
    }

    // Properties
    public double B
    {
        get { return _b; }
        set { _b = ValidateB(value); }
    }

    // Methods
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentException("El lado B debe ser mayor que 0");
        return b;
    }
}