namespace HeritageBackend;

public abstract class GeometricFigure
{
    // Constructors
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    // Properties
    public string Name
    {
        get;
        set;
    }

    // Methods
    public abstract float GetArea();
    public abstract float GetPerimeter();
    public override string ToString()
    {
        return $"Figure: {Name}";
    }
}
