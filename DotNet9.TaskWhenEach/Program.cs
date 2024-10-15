

var tasks = Enumerable.Range(0, 5).Select(x => Task.Run(async () =>
{
    var delay = Random.Shared.Next(1000, 5000);
    await Task.Delay(delay);

    return delay;
}));

var tasks1 = tasks.ToList();

await Task.WhenAll(tasks1);

foreach (var task in tasks1)
{
    Console.WriteLine(task.Result);
}

Console.WriteLine();

var tasks2 = tasks.ToList();

await foreach (var task in Task.WhenEach(tasks2))
{
    Console.WriteLine(task.Result);
}