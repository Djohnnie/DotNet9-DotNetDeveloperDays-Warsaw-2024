// https://github.com/dotnet/dotnet/tree/main/src/runtime/src/libraries/System.Private.CoreLib/src/System/SearchValues
using System.Buffers;



var s = "Hello world.";

int indexOfFirstDot = s.IndexOfAny(['.']);
char[] alphaNumeric = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToArray();
int indexOfFirstAlphaNumeric = s.IndexOfAny(alphaNumeric);


Console.WriteLine($"Index of first dot: {indexOfFirstDot}");
Console.WriteLine($"Index of first alphanumeric character: {indexOfFirstAlphaNumeric}");


var alphaNumeric2 = SearchValues.Create(
    "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
int indexOfFirstAlphaNumeric2 = s.AsSpan().IndexOfAny(alphaNumeric2);


var strings = SearchValues.Create(["Hello", "world", "dotnet", "core", "5", "6", "7", "8", "9", "10"], StringComparison.OrdinalIgnoreCase);
int indexOfFirstString = s.AsSpan().IndexOfAny(strings);