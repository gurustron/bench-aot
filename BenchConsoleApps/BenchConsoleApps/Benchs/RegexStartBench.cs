using BenchConsoleApps;
using BenchmarkDotNet.Attributes;

namespace RegexCompiled.Benchs;

public class RegexStartBench
{
    private static string[] _strings = new[]
    {
        "asdasdasd",
        "1233431432108-235-0120",
        "JJKWQEHM<A<AMSnmsdqjhjMWNQMNW",
        "def",
        "cxcvnnmeoufyre75"
    };

    [Benchmark]
    public bool RegexCompiled()
    {
        bool result = false;
        foreach (var s in _strings)
        {
            var run = RunHelper.Run(
                "/home/gurustron/Projects/bench-aot/BenchConsoleApps/publish/RegexCompiled",
                s);
            result |= run.StartsWith("TRIM", StringComparison.InvariantCultureIgnoreCase);
        }

        return result;
    }
    
    
    [Benchmark]
    public bool RegexOnTheFly()
    {
        bool result = false;
        foreach (var s in _strings)
        {
            var run = RunHelper.Run(
                "/home/gurustron/Projects/bench-aot/BenchConsoleApps/publish/RegexOnTheFly",
                s);
            result |= run.StartsWith("TRIM", StringComparison.InvariantCultureIgnoreCase);
        }

        return result;
    }
}