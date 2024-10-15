using System.Collections.ObjectModel;



var list = new List<int> { 1, 2, 3, 4, 5 };
var roList = list.AsReadOnly();

var dict = new Dictionary<int, string> { [1] = "one", [2] = "two", [3] = "three" };
var roDict = dict.AsReadOnly();

var set = new HashSet<int> { 1, 2, 3, 4, 5 };
var roSet = new ReadOnlySet<int>(set);