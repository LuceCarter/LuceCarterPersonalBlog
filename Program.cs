using Contentful.AspNetCore;
using MudBlazor.Services;
using LuceCarterPersonalBlog.Components;
using LuceCarterPersonalBlog.Models;
using LuceCarterPersonalBlog.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Configure ContentfulSettings
builder.Services.AddContentful(builder.Configuration);
builder.Services.AddScoped<BlogPostService>();
builder.Services.AddSingleton<HtmlRenderer>();




// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
