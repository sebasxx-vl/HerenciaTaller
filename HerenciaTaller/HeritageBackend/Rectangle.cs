namespace HeritageBackend;

public class Rectangle : Square
{
    // Fields
    private double _b;

    // Constructors
    public Rectangle(string name, double a, double b) : base(name, a)
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
        return A * _b;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + _b);
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentException("El lado B debe ser mayor que 0");
        return b;
    }
}