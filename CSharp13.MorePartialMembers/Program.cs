Console.WriteLine("Hello World!");


// Partial classes

partial class MyPartialClass
{
    public void Method1()
    {
        // ...
    }
}

partial class MyPartialClass
{
    public void Method2()
    {
        // ...
    }
}




// Partial methods

partial class MyPartialClass
{
    public partial int PartialMethod(int a, int b);
}

partial class MyPartialClass
{
    public partial int PartialMethod(int a, int b)
    {
        return a + b;
    }
}




// Partial properties

partial class MyPartialClass
{
    public partial int PartialProperty { get; set; }
}

partial class MyPartialClass
{
    private int _member;

    public partial int PartialProperty
    {
        get
        {
            return _member;
        }
        set
        {
            _member = value;
        }
    }
}




// Partial indexers

partial class MyPartialClass
{
    public partial int this[int index] { get; set; }
}

partial class MyPartialClass
{
    private int[] _array = new int[10];

    public partial int this[int index]
    {
        get
        {
            return _array[index];
        }
        set
        {
            _array[index] = value;
        }
    }
}