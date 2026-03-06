namespace HeritageBackend;

public class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Constructors
    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    // Properties
    public double A
    {
        get { return _a; }
        set { _a = ValidateA(value); }
    }

    // Methods
    public override double GetArea()
    {
        return _a * _a;
    }

    public override double GetPerimeter()
    {
        return 4 * _a;
    }

    private double ValidateA(double a)
    {
        if (a <= 0)
            throw new ArgumentException("El lado debe ser mayor que 0");
        return a;
    }
}