using BenchmarkDotNet.Attributes;
using Bogus;

namespace Find.vs.FirstOrDefault;

[RankColumn]
[MemoryDiagnoser]
public class Benchmark
{
    private readonly List<string> stringList = [];
    private readonly int numberItems = 1000;
    private readonly Faker faker = new();

    public Benchmark()
    {
        for (int i = 0; i < numberItems; i++)
        {
            stringList.Add(faker.Lorem.Letter());
        }
    }

    [Benchmark]
    public string FindItem()
    {
        var item = "a";

        var itemFound = stringList.Find(x => x == item);

        return itemFound;
    }

    [Benchmark]
    public string FirstOrDefaultItem()
    {
        var item = "a";

        var itemFound = stringList.FirstOrDefault(x => x == item);

        return itemFound;
    }
}
