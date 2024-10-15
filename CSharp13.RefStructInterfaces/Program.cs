

var obj = new MyRefStruct();
//var boxed = (IMyInterface)obj;



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