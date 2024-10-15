using Microsoft.Extensions.DependencyInjection;


IServiceCollection services = new ServiceCollection();
services.AddSingleton<Apple>();
services.AddSingleton<Banana>();
var serviceProvider = services.BuildServiceProvider();

var instance = ActivatorUtilities.CreateInstance<Test>(serviceProvider);


public class Test
{
    public Test(Apple apple)
    {
        Console.WriteLine("Test(Apple apple)");
    }

    [ActivatorUtilitiesConstructor]
    public Test()
    {
        Console.WriteLine("Test()");
    }

    public Test(Banana banana)
    {
        Console.WriteLine("Test(Banana banana)");
    }
}

public class Apple()
{

}

public class Banana()
{

}