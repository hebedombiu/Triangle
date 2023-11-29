using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benchmarks>();

public class Benchmarks {
    [Benchmark]
    public void Triangle() {
        global::Triangle.Triangle.GetTriangleType(1, 1, 1.414213562373095d);
    }
}