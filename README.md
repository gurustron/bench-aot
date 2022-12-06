# bench-aot

Benchmarking AOT and compiled regexes. Just for LULZ.

From folder publish apps:
```
dotnet publish RegexOnTheFly/RegexOnTheFly.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
dotnet publish RegexCompiled/RegexCompiled.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
dotnet publish RegexAOT/RegexAOT.csproj -c Release -r linux-x64  -o ./publish
```

On my machine:

|        Method |      Mean |     Error |    StdDev |    Median |
|-------------- |----------:|----------:|----------:|----------:|
| RegexCompiled | 569.04 ms | 17.186 ms | 50.134 ms | 554.25 ms |
| RegexOnTheFly | 702.60 ms | 17.798 ms | 51.916 ms | 689.62 ms |
|      RegexAOT |  20.47 ms |  0.403 ms |  0.795 ms |  20.16 ms |

