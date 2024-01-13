using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Reports;

[Config(typeof(Config))]
public class ElementFinder{

    private const int N = 10000;
    private readonly long[] array = new long[N];

    public ElementFinder()
    {
        var rand = new Random();
        for(var i=0;i<N;i++){
            array[i] = rand.NextInt64();
        }
    }

    [Benchmark(Baseline = true)]
    public long First() => array.First();

    [Benchmark]
    public long Indexer() => array[0];

    [Benchmark]
    public long ElementAt() => array.ElementAt(0);

    private class Config : ManualConfig
    {
        public Config()
        {
            SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
        }
    }

}
public class Program
{
    static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(ElementFinder).Assembly).Run(args);
}