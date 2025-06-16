var builder = WebApplication.CreateBuilder(args);

// Configuración de la aplicación
var app = builder.Build();

// Respuesta a la raíz
app.MapGet("/", () => "Hola Mundo desde .NET en Vercel!");

app.Run();