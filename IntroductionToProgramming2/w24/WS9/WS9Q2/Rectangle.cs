using QShape;

class Rectangle : Shape
{
    private float _length;
    private float _width;

    public float Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public float Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public Rectangle(float l, float w)
    {
        Length = l;
        Width = w;
        Type = "Rectangle";
    }

    public override double CalcArea()
    {   
        return Length * Width;
    }

    public override double CalcPerimeter()
    {
        return 2*(Length+Width);
    }

    public override string ToString()
    {
        return "Width: " +Width+" Length: "+Length;
    }
}