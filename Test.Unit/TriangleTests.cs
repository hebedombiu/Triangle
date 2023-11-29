namespace Test.Unit;

public class TriangleTests {
    [Theory]
    [InlineData(10, 1, 1)]
    [InlineData(1, 10, 1)]
    [InlineData(1, 1, 10)]
    [InlineData(-1, -1, -1)]
    [InlineData(-1, 1, 1)]
    [InlineData(-1, 1, 2)]
    [InlineData(0, 0, 0)]
    public void NotTriangle(double a, double b, double c) {
        Assert.Throws<ArgumentException>(() => Triangle.Triangle.GetTriangleType(a, b, c));
    }

    [Theory]
    [InlineData(1.5d)]
    public void IsEquilateralTriangle(double a) {
        Assert.True(Triangle.Triangle.GetTriangleType(a, a, a) < 0);
    }

    [Theory]
    [InlineData(1.0d, 1.5d, 2.0d)]
    public void IsObtuseAngle(double a, double b, double c) {
        Assert.True(Triangle.Triangle.GetTriangleType(a, b, c) > 0);
    }

    [Theory]
    [InlineData(1.0d, 1.0d, 1.414213562373095d)]
    public void IsRightTriangle(double a, double b, double c) {
        Assert.True(Triangle.Triangle.GetTriangleType(a, b, c) == 0);
    }

    [Theory]
    [InlineData(1.0d, 1.0d, 0.5d)]
    public void IsSharpCorner(double a, double b, double c) {
        Assert.True(Triangle.Triangle.GetTriangleType(a, b, c) < 0);
    }
}