// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string strToMatch = args[0];
if (strToMatch is not null)
{
    var regex = new Regex(pattern: "abc|def", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
    Console.WriteLine(regex.IsMatch(strToMatch));
}
