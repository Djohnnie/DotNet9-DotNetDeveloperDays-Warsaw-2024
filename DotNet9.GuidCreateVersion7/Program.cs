var guids = new SortedDictionary<Guid, int>();


Console.WriteLine();
Console.WriteLine("-ORIGINAL-");

for (var i = 0; i < 10; i++)
{
    await Task.Delay(1);
    //var guid = Guid.NewGuid();
    var guid = Guid.CreateVersion7();
    guids.Add(guid, i);
    Console.WriteLine($"{i}: {guid} (v{guid.Version})");
}

Console.WriteLine();
Console.WriteLine("-ORDERED-");

foreach (var (key, value) in guids)
{
    Console.WriteLine($"{value}: {key} (v{key.Version})");
}