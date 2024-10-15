

TimeSpan timeSpanA = TimeSpan.FromSeconds(value: 101.832);
Console.WriteLine($"timeSpanA = {timeSpanA}");

TimeSpan timeSpanB = TimeSpan.FromSeconds(seconds: 101, milliseconds: 832, microseconds: 0);
Console.WriteLine($"timeSpanB = {timeSpanB}");

TimeSpan timeSpanC = TimeSpan.FromMinutes(value: 2.6972);
Console.WriteLine($"timeSpanC = {timeSpanC}");

TimeSpan timeSpanD = TimeSpan.FromMinutes(minutes: 1, seconds: 101, milliseconds: 832, microseconds: 0);
Console.WriteLine($"timeSpanD = {timeSpanD}");

TimeSpan timeSpanE = TimeSpan.FromHours(value: 1.5);
Console.WriteLine($"timeSpanE = {timeSpanE}");

TimeSpan timeSpanF = TimeSpan.FromHours(hours: 1, minutes: 30, seconds: 0, milliseconds: 0, microseconds: 0);
Console.WriteLine($"timeSpanF = {timeSpanF}");

TimeSpan timeSpanG = TimeSpan.FromDays(value: 1.0625);
Console.WriteLine($"timeSpanG = {timeSpanG}");

TimeSpan timeSpanH = TimeSpan.FromDays(days: 1, hours: 1, minutes: 30, seconds: 0, milliseconds: 0, microseconds: 0);
Console.WriteLine($"timeSpanH = {timeSpanH}");


Console.ReadKey();