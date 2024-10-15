

var obj = new MyRefStruct();
DoSomething(obj);

String.Create<MyRefStruct>(64, obj, (stringBuffer, input) => input.MyMethod());


void DoSomething<T>(T obj) where T : IMyInterface, allows ref struct
{
    obj.MyMethod();
}


interface IMyInterface
{
    void MyMethod();
}

ref struct MyRefStruct : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("MyRefStruct.MyMethod");
    }
}