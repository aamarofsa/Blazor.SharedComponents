using Blazor.WebApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Fast.Components.FluentUI;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

UseComponetLib();

await builder.Build().RunAsync();

void UseComponetLib()
{
    if (builder.Configuration.GetValue<string>("ComponentLib:Name") == "Radzen")
    {
        builder.Services.AddScoped<Radzen.DialogService>();
        builder.Services.AddScoped<NotificationService>();
        builder.Services.AddScoped<TooltipService>();
        builder.Services.AddScoped<ContextMenuService>();
        builder.Services.AddRadzenComponents();
        return;
    }

    builder.Services.AddFluentUIComponents();
}
