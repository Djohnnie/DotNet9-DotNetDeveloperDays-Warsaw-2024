using Microsoft.AspNetCore.SignalR.Client;


var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7009/hub")
                .Build();

connection.Closed += async (error) =>
{
    await Task.Delay(new Random().Next(0, 5) * 1000);
    await connection.StartAsync();
};

try
{
    await connection.StartAsync();

    var result1 = await connection.InvokeAsync<string>("DoSomething", new JsonStudent { Name = "Jason", Grade = 7.5M });
    Console.WriteLine(result1);
    var result2 = await connection.InvokeAsync<string>("DoSomething", new JsonEmployee { Name = "Carl", Salary = 3400M });
    Console.WriteLine(result2);
    var result3 = await connection.InvokeAsync<string>("DoSomething", new JsonPerson { Name = "John" });
    Console.WriteLine(result3);

    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

public class JsonPerson
{
    public string Name { get; set; }
}

public class JsonStudent : JsonPerson
{
    public decimal Grade { get; set; }
}

public class JsonEmployee : JsonPerson
{
    public decimal Salary { get; set; }
}