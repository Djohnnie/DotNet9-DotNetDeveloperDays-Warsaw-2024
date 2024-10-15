namespace AspNetCore9.BlazorComponentConstructorInjection.Components;

public partial class DemoComponent(IConfiguration configuration)
{
    public string Path { get; set; }

    protected override void OnInitialized()
    {
        Path = configuration.GetValue<string>("Path");
    }
}