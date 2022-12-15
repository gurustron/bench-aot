# bench-aot

Benchmarking AOT and compiled regexes. Just for LULZ.

From folder publish apps:
```
dotnet publish RegexOnTheFly/RegexOnTheFly.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
dotnet publish RegexCompiled/RegexCompiled.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
dotnet publish RegexCompiledR2R/RegexCompiledR2R.csproj --sc -c Release -r linux-x64  -o ./publish -p:PublishSingleFile=true 
dotnet publish RegexCompiledR2R/RegexCompiledR2R.csproj --sc -c Release -r linux-x64  -o ./publish/R2R  
dotnet publish RegexAOT/RegexAOT.csproj -c Release -r linux-x64  -o ./publish
```

On my machine:

|             Method |      Mean |     Error |    StdDev |    Median |
|------------------- |----------:|----------:|----------:|----------:|
|      RegexCompiled | 606.71 ms | 18.560 ms | 54.726 ms | 598.26 ms |
| RegexCompiledR2RSF | 600.77 ms | 18.113 ms | 52.550 ms | 596.71 ms |
|   RegexCompiledR2R | 591.89 ms | 16.544 ms | 48.259 ms | 579.07 ms |
|      RegexOnTheFly | 744.10 ms | 19.698 ms | 56.834 ms | 734.80 ms |
|           RegexAOT |  23.21 ms |  0.530 ms |  1.537 ms |  22.79 ms |


