using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Configurar la aplicación
var app = builder.Build();

// Responder a la raíz
app.MapGet("/", () => "Hola Mundo desde .NET en Vercel!");

app.Run();
