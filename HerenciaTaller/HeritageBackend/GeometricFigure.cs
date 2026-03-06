namespace HeritageBackend;

public abstract class GeometricFigure
{
    // Properties
    public string Name { get; set; } = string.Empty;

    // Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"Figure: {Name}";
    }
}