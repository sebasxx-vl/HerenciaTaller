namespace HeritageBackend;

public class Rhombus : Square
{
    // Fields
    private double _d1;
    private double _d2;

    // Constructors
    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        Name = name;
        D1 = d1;
        D2 = d2;
    }

    // Properties
    public double D1
    {
        get { return _d1; }
        set { _d1 = ValidateD1(value); }
    }

    public double D2
    {
        get { return _d2; }
        set { _d2 = ValidateD2(value); }
    }

    // Methods
    public override double GetArea()
    {
        return (_d1 * _d2) / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * Math.Sqrt(Math.Pow(_d1 / 2, 2) + Math.Pow(_d2 / 2, 2));
    }

    private double ValidateD1(double d1)
    {
        if (d1 <= 0)
            throw new ArgumentException("La diagonal 1 debe ser mayor que 0");
        return d1;
    }

    private double ValidateD2(double d2)
    {
        if (d2 <= 0)
            throw new ArgumentException("La diagonal 2 debe ser mayor que 0");
        return d2;
    }
}