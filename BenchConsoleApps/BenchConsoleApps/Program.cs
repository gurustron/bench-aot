using BenchmarkDotNet.Running;
using RegexCompiled.Benchs;

// requires published runnable artifacts 
// and potentially change of hardcoded path
var summary = BenchmarkRunner.Run<RegexStartBench>();

