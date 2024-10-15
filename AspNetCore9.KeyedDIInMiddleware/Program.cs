var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddKeyedSingleton<MySingletonClass>("singleton");
builder.Services.AddKeyedScoped<MyScopedClass>("scoped");

var app = builder.Build();

app.UseMiddleware<TestMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/status", () =>
{
    return Results.Redirect("https://media1.tenor.com/m/B9OjyPMq5pIAAAAC/fine-this-is-fine.gif");
})
.WithName("GetStatus");

app.Run();

public class TestMiddleware
{
    private readonly RequestDelegate _next;

    public TestMiddleware(RequestDelegate next, [FromKeyedServices("singleton")] MySingletonClass singleton)
    {
        _next = next;
        Console.WriteLine(singleton);
    }

    public async Task InvokeAsync(HttpContext context, [FromKeyedServices("scoped")] MyScopedClass scoped)
    {
        Console.WriteLine(scoped);

        await _next(context);
    }
}

public class MySingletonClass
{
    public override string ToString()
    {
        return nameof(MySingletonClass);
    }
}

public class MyScopedClass
{
    public override string ToString()
    {
        return nameof(MyScopedClass);
    }
}