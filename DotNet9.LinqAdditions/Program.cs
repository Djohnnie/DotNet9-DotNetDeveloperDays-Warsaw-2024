

/////////////////
//// CountBy
/////////////////

string sourceText = """
    Lorem ipsum dolor sit amet, consectetur adipiscing elit.
    Sed non risus. Suspendisse lectus tortor, dignissim sit amet, 
    adipiscing nec, ultricies sed, dolor. Cras elementum ultrices amet diam.
    """;

var splitChars = new char[] { ' ', '.', ',', '\r', '\n' };


// Find the most frequent word in a piece of text
KeyValuePair<string, int> mostFrequentWord1 = sourceText
    .Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
    .Select(word => word.ToLowerInvariant())
    .GroupBy(word => word)
    .ToDictionary(group => group.Key, group => group.Count())
    .MaxBy(pair => pair.Value);

Console.WriteLine(mostFrequentWord1.Key);

// Find the most frequent word in a piece of text
KeyValuePair<string, int> mostFrequentWord2 = sourceText
    .Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
    .Select(word => word.ToLowerInvariant())
    .CountBy(word => word)
    .MaxBy(pair => pair.Value);

Console.WriteLine(mostFrequentWord2.Key);



/////////////////
//// AggregateBy
/////////////////

var data = new List<Temp>
{
    new Temp { Key = "0", Value = 42 },
    new Temp { Key = "1", Value = 5 },
    new Temp { Key = "2", Value = 4 },
    new Temp { Key = "1", Value = 10 },
    new Temp { Key = "0", Value = 25 }
};

var result1 = data
    .GroupBy(keySelector: entry => entry.Key)
    .ToDictionary(x => x.Key, x => x.Aggregate(seed: 0, (totalScore, curr) => totalScore + curr.Value));

foreach (var pair in result1)
{
    Console.WriteLine($"({pair.Key}, {pair.Value})");
}

var result2 = data
    .AggregateBy(keySelector: entry => entry.Key, seed: 0, (totalScore, curr) => totalScore + curr.Value);

foreach (var pair in result2)
{
    Console.WriteLine($"({pair.Key}, {pair.Value})");
}


/////////////////
//// Index
/////////////////

IEnumerable<string> lines = ["line 1", "line 2", "line 3", "line 4"];

foreach ((int index, string line) in lines.Select((line, index) => (index, line)))
{
    Console.WriteLine($"Line index: {index}, Line: {line}");
}

foreach ((int index, string line) in lines.Index())
{
    Console.WriteLine($"Line index: {index}, Line: {line}");
}






class Temp
{
    public string Key { get; set; }
    public int Value { get; set; }
}