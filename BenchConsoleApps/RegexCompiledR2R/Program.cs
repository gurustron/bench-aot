using System.Text.RegularExpressions;

string strToMatch = args[0];
if (strToMatch is not null)
{
    Console.WriteLine(AbcOrDefGeneratedRegex().IsMatch(strToMatch));
}

public partial class Program
{
    [GeneratedRegex("abc|def", RegexOptions.IgnoreCase | RegexOptions.Compiled, "en-US")]
    public static partial Regex AbcOrDefGeneratedRegex();
}