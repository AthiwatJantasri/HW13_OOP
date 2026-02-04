using System;

// Interface Shaper
interface IShaper {
    double Area();
    double Perimeter();
    void Info();
}

// Struct: Rectangle
struct Rectangle : IShaper {
    public double Width;
    public double Height;

    public Rectangle(double width, double height) {
        Width = width;
        Height = height;
    }

    public double Area() {
        return Width * Height;
    }

    public double Perimeter() {
        return 2 * (Width + Height);
    }

    public void Info() {
        Console.WriteLine("--- Rectangle (Struct) ---");
        Console.WriteLine($"Width    : {Width:F2}");
        Console.WriteLine($"Height   : {Height:F2}");
        Console.WriteLine($"Area     : {Area():F2}");
        Console.WriteLine($"Perimeter: {Perimeter():F2}");
    }
}

// Struct: Circle
struct Circle : IShaper {
    public double Radius;

    public Circle(double radius) {
        Radius = radius;
    }

    public double Area() {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double Perimeter() {
        return 2 * Math.PI * Radius;
    }

    public void Info() {
        Console.WriteLine("--- Circle (Struct) ---");
        Console.WriteLine($"Radius   : {Radius:F2}");
        Console.WriteLine($"Area     : {Area():F2}");
        Console.WriteLine($"Perimeter: {Perimeter():F2}");
    }
}

class Program {
    static void Main() {
        // ทดสอบสร้าง instance
        Rectangle rect = new Rectangle(10, 20);
        Circle circle = new Circle(7);

        rect.Info();
        Console.WriteLine();
        circle.Info();
    }
}
