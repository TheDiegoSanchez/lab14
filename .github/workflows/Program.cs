var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hola Mundo desde .NET en Vercel!");

app.Run();