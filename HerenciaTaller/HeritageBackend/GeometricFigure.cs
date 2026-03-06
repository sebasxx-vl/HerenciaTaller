namespace HeritageBackend;
public abstract class GeometricFigure
{
    // Properties
    public string Name { get; set; } = string.Empty;

    // Methods
    public abstract float GetArea();
    public abstract float GetPerimeter();

    public override string ToString()
    {
        return $"Figure: {Name}";
    }
}