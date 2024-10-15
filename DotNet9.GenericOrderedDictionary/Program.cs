

var dict = new OrderedDictionary<string, WindDirection>
{
    ["E"] = WindDirection.East,
    ["S"] = WindDirection.South,
    ["Z"] = WindDirection.West
};

dict.Add("W", WindDirection.West);
dict.Insert(0, "N", WindDirection.North);
dict.RemoveAt(dict.Count - 2);

foreach (var item in dict)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}


enum WindDirection
{
    North,
    East,
    South,
    West
}