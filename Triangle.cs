using System;

public class Triangle
{
    
    private double a;
    private double b;
    private double c;

    
    public Triangle(double A, double B, double C)
    {
        a = A;
        b = B;
        c = C;
    }

    
    public string OutputA()
    {
        return Convert.ToString(a);
    }

    
    public string OutputB()
    {
        return Convert.ToString(b);
    }

    
    public string OutputC()
    {
        return Convert.ToString(c);
    }

    
    public double Perimeter()
    {
        return a + b + c;
    }

    
    public double Surface()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    
    public double GetSetA
    {
        get { return a; }
        set { a = value; }
    }

    public double GetSetB
    {
        get { return b; }
        set { b = value; }
    }

    public double GetSetC
    {
        get { return c; }
        set { c = value; }
    }

    
    public bool ExistTriangle
    {
        get
        {
            
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
