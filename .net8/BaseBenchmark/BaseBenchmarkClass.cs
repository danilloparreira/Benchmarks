using BenchmarkDotNet.Attributes;
using Bogus;

namespace BaseBenchmark;

[RankColumn]
[MemoryDiagnoser]
public abstract class BaseBenchmarkClass
{
    [Params(9, 99, 999, 9999, 99999)]
    public int numberItems;

    protected readonly Faker faker = new();
}
