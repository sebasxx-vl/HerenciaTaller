namespace HeritageBackend;
public class Circle : GeometricFigure
{
    // Fields
    private float _r;

    // Constructors
    public Circle(float r)
    {
        Name = "Circle";
        R = r;
    }

    // Properties
    public float R
    {
        get { return _r; }
        set { _r = ValidateR(value); }
    }

    // Methods
    public override float GetArea()
    {
        return MathF.PI * _r * _r;
    }

    public override float GetPerimeter()
    {
        return 2 * MathF.PI * _r;
    }

    private float ValidateR(float r)
    {
        if (r <= 0)
            throw new ArgumentException("El radio debe ser mayor que 0");
        return r;
    }
}