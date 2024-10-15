using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Runtime.InteropServices.JavaScript.JSType;


#pragma warning disable SYSLIB0011 // Type or member is obsolete
BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete

try
{
    var person = new Person
    {
        FirstName = "John",
        LastName = "Doe",
        Age = 25
    };

    using var memoryStream = new MemoryStream();
    formatter.Serialize(memoryStream, person);
}
catch (Exception ex)
{
    Console.WriteLine($"Failed to serialize: {ex.Message}");
}


class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}