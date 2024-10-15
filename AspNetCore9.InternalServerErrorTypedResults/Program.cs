using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/status", () =>
{
    var problemDetails = new ProblemDetails
    {
        Status = 500,
        Title = "Oooopsie error!",
        Type = "ERROR",
        Detail = "There was a little oooopsie from our side. Please try again!"
    };

    return TypedResults.InternalServerError(problemDetails);
});

app.Run();