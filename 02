using System;

interface IShaper {
    double Area();
    double Perimeter();
    void Info();
}

// Record: Rectangle (Primary Constructor)
record Rectangle(double Width, double Height) : IShaper {
    public double Area() => Width * Height;
    public double Perimeter() => 2 * (Width + Height);
    
    public void Info() {
        Console.WriteLine("--- Rectangle (Record) ---");
        Console.WriteLine($"Width: {Width}, Height: {Height}");
        Console.WriteLine($"Area: {Area():F2}, Perimeter: {Perimeter():F2}");
    }
}

// Record: Circle
record Circle(double Radius) : IShaper {
    public double Area() => Math.PI * Math.Pow(Radius, 2);
    public double Perimeter() => 2 * Math.PI * Radius;

    public void Info() {
        Console.WriteLine("--- Circle (Record) ---");
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {Area():F2}, Perimeter: {Perimeter():F2}");
    }
}
