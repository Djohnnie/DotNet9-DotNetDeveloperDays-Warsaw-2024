using System.Text.Json;
using System.Text.Json.Schema;


var options = new JsonSerializerOptions
{
    WriteIndented = true,
    IndentCharacter = '\t',
    IndentSize = 2,
};

var json1 = JsonSerializer.Serialize(new { Value = 1 }, options);
var json2 = JsonSerializer.Serialize(new { Value = 1 }, JsonSerializerOptions.Web);

Console.WriteLine(json1);
Console.WriteLine();
Console.WriteLine(json2);

Console.ReadKey();

Console.WriteLine();
Console.WriteLine();

var schema = JsonSchemaExporter.GetJsonSchemaAsNode(JsonSerializerOptions.Default, typeof(Person));
Console.WriteLine(schema);

Console.ReadKey();

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string[] Hobbies { get; set; }
    public Address Address { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
}