

var buffer = new Buffer10
{
    [^1] = 1,
    [^2] = 2,
    [^3] = 3,
    [^4] = 4,
    [^5] = 5,
    [^6] = 6,
    [^7] = 7,
    [^8] = 8,
    [^9] = 9,
    [^10] = 10
};

for (int i = 0; i < buffer.Length; i++)
{
    Console.WriteLine(buffer[i]);
}

Console.ReadKey();


struct Buffer10
{
    private int[] _buffer = new int[10];

    public Buffer10() { }

    public int Length => _buffer.Length;

    public int this[int x]
    {
        get => _buffer[x];
        set { _buffer[x] = value; }
    }
}