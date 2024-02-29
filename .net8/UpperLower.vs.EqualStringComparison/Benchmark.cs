using BaseBenchmark;
using BenchmarkDotNet.Attributes;

namespace UpperLower.vs.EqualStringComparison;

public class Benchmark : BaseBenchmarkClass
{
    private readonly Dictionary<string, string> stringList = [];

    public Benchmark()
    {
        for (int i = 0; i < numberItems; i++)
        {
            stringList.Add(faker.Lorem.Letter(), faker.Lorem.Letter());
        }
    }

    [Benchmark(Baseline = true)]
    public bool Lower()
    {
        bool lower = true;

        foreach (var item in stringList)
        {
            lower = item.Key.ToLower() == item.Value.ToLower();
        }

        return lower;
    }

    [Benchmark]
    public bool Upper()
    {
        bool upper = true;

        foreach (var item in stringList)
        {
            upper = item.Key.ToUpper() == item.Value.ToUpper();
        }

        return upper;
    }

    [Benchmark]
    public bool IgnoreCase()
    {
        bool ignore = true;

        foreach (var item in stringList)
        {
            ignore = string.Equals(item.Key, item.Value, StringComparison.OrdinalIgnoreCase);
        }

        return ignore;
    }
}
