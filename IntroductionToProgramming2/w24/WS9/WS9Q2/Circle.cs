using QShape;

class Circle : Shape
{
    private float _radius;

    public float Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public Circle(float r)
    {
        Radius = r;
        Type = "Circle";
    }


    public override double CalcArea()
    {
        return Radius * Math.PI;
    }

    public override double CalcPerimeter()
    {
        return 2 * Math.PI * Radius;
    }


    public override string ToString()
    {
        return "Radius: " + Radius;
    }
}