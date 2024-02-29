using BenchmarkDotNet.Running;

namespace Any.vs.Exists.vs.Contains;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmark>(config: null, args: args);
        Console.ReadLine();
    }
}
