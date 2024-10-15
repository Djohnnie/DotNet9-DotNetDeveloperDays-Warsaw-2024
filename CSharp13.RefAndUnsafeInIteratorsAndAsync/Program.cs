
await Method();



async Task Method()
{
    int number = 42;
    ref int x = ref number;

    await Task.Delay(1000);

    //ref int y = ref x;
}

IEnumerable<int> Iterator()
{
    int number = 42;
    ref int x = ref number;

    yield return x;

    //ref int y = ref x;
}