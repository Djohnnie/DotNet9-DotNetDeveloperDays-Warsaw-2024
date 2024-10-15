using System.Text.RegularExpressions;



foreach (string s in Regex.Split("Hello, world! How are you?", "[aeiou]"))
{
    Console.WriteLine($"Split: \"{s}\"");
}

ReadOnlySpan<char> input = "Hello, world! How are you?";
foreach (Range r in Regex.EnumerateSplits(input, "[aeiou]"))
{
    Console.WriteLine($"Split: \"{input[r]}\"");
}