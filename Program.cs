//using Microsoft.Extensions.Options;
using Platform;
using Platform.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Hello World!");
});


app.Run();
