using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<Dependency1>();
serviceCollection.AddTransient<Dependency2>();
serviceCollection.AddTransient<Dependency3>();
var serviceProvider = serviceCollection.BuildServiceProvider();

_ = Activator.CreateInstance<Service>();
_ = ActivatorUtilities.CreateInstance<Service>(serviceProvider);


public class Service
{
    public Service()
    {
        Console.WriteLine(MethodBase.GetCurrentMethod());
    }

    [ActivatorUtilitiesConstructor]
    public Service(Dependency1 d1, Dependency2 d2)
    {
        Console.WriteLine(MethodBase.GetCurrentMethod());
    }

    public Service(Dependency1 d1, Dependency2 d2, Dependency3 d3)
    {
        Console.WriteLine(MethodBase.GetCurrentMethod());
    }
}

public class Dependency1
{

}

public class Dependency2
{

}

public class Dependency3
{

}