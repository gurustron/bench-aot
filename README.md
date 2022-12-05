# bench-aot

Benchmarking AOT and compiled regexes. Just for LULZ.

From folder publish apps:
```
dotnet publish RegexOnTheFly/RegexOnTheFly.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
dotnet publish RegexCompiled/RegexCompiled.csproj --sc -p:PublishSingleFile=true -c Release -r linux-x64  -o ./publish
```