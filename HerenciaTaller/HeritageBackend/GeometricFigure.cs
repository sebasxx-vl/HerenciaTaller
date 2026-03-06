namespace HeritageBackend;

public abstract class GeometricFigure
{
    // Constructors
    protected GeometricFigure()
    {
        Name = string.Empty;
    }

    // Properties
    public string Name { get; set; }

    // Methods
    public abstract float GetArea();
    public abstract float GetPerimeter();

    public override string ToString()
    {
        return $"Figure: {Name}";
    }
}