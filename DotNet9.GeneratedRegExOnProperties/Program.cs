using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text.RegularExpressions;



BenchmarkRunner.Run<RegExBenchmarks>();


public partial class RegExBenchmarks
{

    [GeneratedRegex(@"abc|def", RegexOptions.IgnoreCase)]
    public static partial Regex MyPartialMethodRegex();

    [GeneratedRegex(@"abc|def", RegexOptions.IgnoreCase)]
    public static partial Regex MyPartialPropertyRegex { get; }

    public static Regex _regex = new Regex(@"abc|def");

    [Benchmark(Description = "Partial Method RegEx Code Generator")]
    public bool PartialMethodRegexCodeGenerator()
    {
        return MyPartialMethodRegex().IsMatch("abcdefghijklmnopqrstuvwxyz");
    }

    [Benchmark(Description = "Partial Property RegEx Code Generator")]
    public bool PartialPropertyRegexCodeGenerator()
    {
        return MyPartialPropertyRegex.IsMatch("abcdefghijklmnopqrstuvwxyz");
    }

    [Benchmark(Description = "Static RegEx")]
    public bool StaticRegex()
    {
        return _regex.IsMatch("abcdefghijklmnopqrstuvwxyz");
    }
}