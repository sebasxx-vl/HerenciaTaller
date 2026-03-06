namespace HeritageBackend;

public class Circle : GeometricFigure
{
    // Fields
    private double _r;

    // Constructors
    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    // Properties
    public double R
    {
        get { return _r; }
        set { _r = ValidateR(value); }
    }

    // Methods
    public override double GetArea()
    {
        return Math.PI * _r * _r;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _r;
    }

    private double ValidateR(double r)
    {
        if (r <= 0)
            throw new ArgumentException("El radio debe ser mayor que 0");
        return r;
    }
}