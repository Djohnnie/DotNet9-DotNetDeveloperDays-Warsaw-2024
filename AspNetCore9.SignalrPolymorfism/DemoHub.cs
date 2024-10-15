using Microsoft.AspNetCore.SignalR;
using System.Text.Json.Serialization;

namespace AspNetCore9.SignalrPolymorfism;

public class DemoHub : Hub
{
    public Task<string> DoSomething(JsonPerson person)
    {
        if (person is JsonStudent student)
        {
            return Task.FromResult($"{nameof(JsonStudent)} {person.Name}");
        }
        else if (person is JsonEmployee employee)
        {
            return Task.FromResult($"{nameof(JsonEmployee)} {person.Name}");
        }
        else
        {
            return Task.FromResult($"{nameof(JsonPerson)} {person.Name}");
        }
    }
}

[JsonPolymorphic]
[JsonDerivedType(typeof(JsonStudent), nameof(JsonStudent))]
[JsonDerivedType(typeof(JsonEmployee), nameof(JsonEmployee))]
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