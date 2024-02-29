using BaseBenchmark;
using BenchmarkDotNet.Attributes;

namespace Any.vs.Exists.vs.Contains;

public class Benchmark : BaseBenchmarkClass
{
    private readonly List<string> stringList = [];

    public Benchmark()
    {
        for (int i = 0; i < numberItems; i++)
        {
            stringList.Add(faker.Lorem.Letter());
        }
    }

    [Benchmark(Baseline = true)]
    [Arguments("a")]
    public bool ExistsItem(string item)
    {
        var exists = stringList.Exists(x => x == item);

        return exists;
    }

    [Benchmark]
    [Arguments("a")]
    public bool AnyItem(string item)
    {
        var any = stringList.Any(x => x == item);

        return any;
    }

    [Benchmark]
    [Arguments("a")]
    public bool ContainsItem(string item)
    {
        var contains = stringList.Contains(item);

        return contains;
    }
}
