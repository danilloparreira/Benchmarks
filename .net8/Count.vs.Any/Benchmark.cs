using BaseBenchmark;
using BenchmarkDotNet.Attributes;

namespace Count.vs.Any;

public class Benchmark : BaseBenchmarkClass
{
    private readonly List<string> stringList = [];

    public Benchmark()
    {
        for (int i = 0; i < numberItems; i++)
        {
            stringList.Add(faker.Lorem.Word());
        }
    }

    [Benchmark(Baseline = true)]
    public bool CountListItems()
    {
        var count = stringList.Count > 0;

        return count;
    }

    [Benchmark]
    public bool AnyListItems()
    {
        var any = stringList.Any();

        return any;
    }
}
