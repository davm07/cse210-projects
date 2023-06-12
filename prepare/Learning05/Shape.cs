using System;

public abstract class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string MyColor
    {
        get { return _color; }
        set { _color = value; }
    }

    public abstract double GetArea();
    
} 