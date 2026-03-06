namespace HeritageBackend;

public class Parallelogram : Rectangle
{
    // Fields
    private double _h;

    // Constructors
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        Name = name;
        H = h;
    }

    // Properties
    public double H
    {
        get { return _h; }
        set { _h = ValidateH(value); }
    }

    // Methods
    public override double GetArea()
    {
        return B * _h;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("La altura debe ser mayor que 0");
        return h;
    }
}