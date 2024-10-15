using System.Collections;


DoSomethingFirst(1, 2, 3, 4, 5);
DoSomethingSecond(1, 2, 3, 4, 5);
DoSomethingThird(1, 2, 3, 4, 5);
DoSomethingFourth(1, 2, 3, 4, 5);


static void DoSomethingFirst(params int[] values)
{
    Console.WriteLine(values.Length);
}

static void DoSomethingSecond(params IEnumerable<int> values)
{
    Console.WriteLine(values.Count());
}

static void DoSomethingThird(params List<int> values)
{
    Console.WriteLine(values.Count);
}

static void DoSomethingFourth(params MyClass values)
{
}

class MyClass : IEnumerable<int>
{
    public void Add(int value)
    {
        // NOP
    }

    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}