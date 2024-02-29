using BaseBenchmark;
using BenchmarkDotNet.Attributes;

namespace Find.vs.FirstOrDefault;

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
    public string FindItem(string item)
    {
        var itemFound = stringList.Find(x => x == item);

        return itemFound;
    }

    [Benchmark]
    [Arguments("a")]
    public string FirstOrDefaultItem(string item)
    {
        var itemFound = stringList.FirstOrDefault(x => x == item);

        return itemFound;
    }
}
