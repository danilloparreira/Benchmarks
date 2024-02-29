using BenchmarkDotNet.Running;

namespace UpperLower.vs.EqualStringComparison;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmark>(config: null, args: args);
        Console.ReadLine();
    }
}
