using System.Diagnostics;

namespace BenchConsoleApps;

public class RunHelper
{
    public static string Run(string exePath, params string[] args)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = exePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = string.Join(" ", args)
            }
        };

        process.Start();
        var readToEnd = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        return readToEnd;
    }
}