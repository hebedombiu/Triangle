using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benchmarks>();

public class Benchmarks {
    [Benchmark]
    public void Triangle1() {
        global::Triangle.Triangle.GetTriangleType(1.414213562373095d, 1, 1);
    }

    [Benchmark]
    public void Triangle2() {
        global::Triangle.Triangle.GetTriangleType(1, 1.414213562373095d, 1);
    }

    [Benchmark]
    public void Triangle3() {
        global::Triangle.Triangle.GetTriangleType(1, 1, 1.414213562373095d);
    }

    [Benchmark]
    public void Triangle4() {
        global::Triangle.Triangle.GetTriangleType(1, 1, 1);
    }
}