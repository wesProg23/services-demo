using BlazorApp1.Data;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IMainAPI, ConsumoAPI>();
builder.Services.AddSingleton<ISecAPI, ConsumoAPI>();
builder.Services.AddScoped<ReqHeader>();
builder.Services.AddScoped<IHetoDataMain, HetoDataMain>();
builder.Services.AddScoped<IHetoDataSec, HetoDataSec>();

var app = builder.Build();

app.Services.GetService<IMainAPI>()!.SetEnderecoServidor("hetosoft.ddns.com.br:8096");
app.Services.GetService<ISecAPI>()!.SetEnderecoServidor("127.0.0.1:63839"); 

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
