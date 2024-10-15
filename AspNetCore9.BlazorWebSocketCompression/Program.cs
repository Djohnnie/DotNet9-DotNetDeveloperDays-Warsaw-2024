using AspNetCore9.BlazorWebSocketCompression.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(o =>
    {
        o.ContentSecurityFrameAncestorsPolicy = "'none'";
        o.DisableWebSocketCompression = true;
    });

app.Run();