namespace Triangle;

public static class Triangle {
    // точность
    private const double Precision = 1E-15;

    public static double GetTriangleType(double a, double b, double c) {
        if (!(a + b > c && a + c > b && b + c > a)) throw new ArgumentException("is not triangle");

        // если квадрат длинной стороны больше суммы квадратов других, то угол тупой, если меньше, то острый, иначе прямоугольный

        if (a > b && a > c) {
            var result = a * a - (b * b + c * c);
            if (Math.Abs(result) < Precision) return 0;
            return result;
        }

        if (b > a && b > c) {
            var result = b * b - (a * a + c * c);
            if (Math.Abs(result) < Precision) return 0;
            return result;
        }

        if (c > a && c > b) {
            var result = c * c - (a * a + b * b);
            if (Math.Abs(result) < Precision) return 0;
            return result;
        }

        // равносторонний треугольник, все углы острые
        return -1;
    }
}