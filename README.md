# bench-aot

Benchmarking AOT and compiled regexes. Just for LULZ.

From folder publish apps:
```
dotnet publish RegexOnTheFly/RegexOnTheFly.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
dotnet publish RegexCompiled/RegexCompiled.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
```

On my machine:

|        Method |     Mean |    Error |   StdDev |
|-------------- |---------:|---------:|---------:|
| RegexCompiled | 502.0 ms |  9.87 ms | 15.65 ms |
| RegexOnTheFly | 635.8 ms | 12.59 ms | 24.55 ms |
