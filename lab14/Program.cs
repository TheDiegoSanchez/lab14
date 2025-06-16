var builder = WebApplication.CreateBuilder(args);

// Crear el app web
var app = builder.Build();

// Responder a la ruta raíz
app.MapGet("/", () => "Hola Mundo desde .NET en Vercel!");

app.Run();