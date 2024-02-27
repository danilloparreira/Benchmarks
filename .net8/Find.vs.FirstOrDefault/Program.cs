using BenchmarkDotNet.Running;

namespace Find.vs.FirstOrDefault;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmark>(config: null, args: args);
        Console.ReadLine();
    }
}
