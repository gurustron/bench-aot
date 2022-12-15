using BenchConsoleApps;
using BenchmarkDotNet.Attributes;

namespace RegexCompiled.Benchs;

public class RegexStartBench
{
    private const string Root = "/home/gurustron/Projects/bench-aot/BenchConsoleApps/publish";

    private static readonly string[] _strings =
    {
        "asdasdasd",
        "1233431432108-235-0120",
        "JJKWQEHM<A<AMSnmsdqjhjMWNQMNW",
        "def",
        "cxcvnnmeoufyre75"
    };

    [Benchmark]
    public bool RegexCompiled() => RunBench($"{Root}/RegexCompiled");
    
    [Benchmark]
    public bool RegexCompiledR2RSF() => RunBench($"{Root}/RegexCompiledR2R");
    
    [Benchmark]
    public bool RegexCompiledR2R() => RunBench($"{Root}/R2R/RegexCompiledR2R");

    [Benchmark]
    public bool RegexOnTheFly() => RunBench($"{Root}/RegexOnTheFly");

    [Benchmark]
    public bool RegexAOT() => RunBench($"{Root}/RegexAOT");

    private static bool RunBench(string path)
    {
        var result = false;
        foreach (var s in _strings)
        {
            var run = RunHelper.Run(
                path,
                s);
            result |= run.StartsWith("TRUE", StringComparison.InvariantCultureIgnoreCase);
        }

        return result;
    }
}