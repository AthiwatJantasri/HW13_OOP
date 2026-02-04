// Interface Shaper
interface Shaper {
    double area();
    double perimeter();
    void info();
}

// Record: Rectangle
// Record ใน Java จะสร้าง constructor และ getter ให้เองอัตโนมัติ
record Rectangle(double width, double height) implements Shaper {
    @Override
    public double area() {
        return width * height;
    }

    @Override
    public double perimeter() {
        return 2 * (width + height);
    }

    @Override
    public void info() {
        System.out.println("--- Rectangle (Record) ---");
        System.out.printf("Width    : %.2f%n", width);
        System.out.printf("Height   : %.2f%n", height);
        System.out.printf("Area     : %.2f%n", area());
        System.out.printf("Perimeter: %.2f%n", perimeter());
    }
}

// Record: Circle
record Circle(double radius) implements Shaper {
    @Override
    public double area() {
        return Math.PI * Math.pow(radius, 2);
    }

    @Override
    public double perimeter() {
        return 2 * Math.PI * radius;
    }

    @Override
    public void info() {
        System.out.println("--- Circle (Record) ---");
        System.out.printf("Radius   : %.2f%n", radius);
        System.out.printf("Area     : %.2f%n", area());
        System.out.printf("Perimeter: %.2f%n", perimeter());
    }
}

public class Main {
    public static void main(String[] args) {
        Rectangle r = new Rectangle(10, 20);
        Circle c = new Circle(7);

        r.info();
        System.out.println();
        c.info();
    }
}
