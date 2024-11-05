public class Triangle
{
    public double GetSetA { get; }
    public double GetSetB { get; }
    public double GetSetC { get; }
    public string TriangleType { get; }
    public bool ExistTriangle { get; }

    public Triangle(double a, double b, double c)
    {
        GetSetA = a;
        GetSetB = b;
        GetSetC = c;

        // Logic to determine if the triangle exists and its type
        ExistTriangle = (a + b > c) && (a + c > b) && (b + c > a);
        TriangleType = DetermineTriangleType(a, b, c);
    }

    public double Perimeter()
    {
        return GetSetA + GetSetB + GetSetC;
    }

    public double Area()
    {
        // Using Heron's formula
        double s = Perimeter() / 2;
        return Math.Sqrt(s * (s - GetSetA) * (s - GetSetB) * (s - GetSetC));
    }

    private string DetermineTriangleType(double a, double b, double c)
    {
        // Logic to determine triangle type (Equilateral, Isosceles, etc.)
        if (a == b && b == c) return "Равносторонний";
        if (a == b || b == c || a == c) return "Равнобедренный";
        if (IsRightTriangle(a, b, c)) return "Прямоугольный";
        if (a < b + c && b < a + c && c < a + b)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2)) return "Остроугольный";
            else return "Тупоугольный";
        }
        return "Не существует";
    }

    private bool IsRightTriangle(double a, double b, double c)
    {
        // Check for right triangle using Pythagorean theorem
        return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
               Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) ||
               Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2);
    }
}
