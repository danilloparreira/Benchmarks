using BenchmarkDotNet.Attributes;
using Bogus;

namespace Count.vs.Any;

[RankColumn]
[MemoryDiagnoser]
public class Benchmark
{
    private readonly int numberItems = 1000;
    private readonly Faker faker = new();

    [Benchmark]
    public bool CountListItems()
    {
        var list = new List<string>();

        for (int i = 0; i < numberItems; i++)
        {
            list.Add(faker.Lorem.Word());
        }

        var count = list.Count > 0;

        return count;
    }

    [Benchmark]
    public bool AnyListItems()
    {
        var list = new List<string>();

        for (int i = 0; i < numberItems; i++)
        {
            list.Add(faker.Lorem.Word());
        }

        var any = list.Any();

        return any;
    }
}
