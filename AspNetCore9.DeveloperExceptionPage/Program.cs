var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/status", () =>
{
    throw new InvalidOperationException("Ooopsie!");
})
.WithName("Status");

app.Run();