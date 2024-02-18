using BenchmarkDotNet.Running;

namespace Count.vs.Any;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmark>(config: null, args: args);
        Console.ReadLine();
    }
}
