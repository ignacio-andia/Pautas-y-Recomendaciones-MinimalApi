using practicaX.Endpoints;

var builder = WebApplication.CreateBuilder(args);
//1
builder.Services.AddOpenApi();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "mini Proyecto Api - Prueba");
    });
}

app.MapGet("/", () => "proyecto con swagger");

var api = app.MapGroup("/api");
api.MapPLanetEndpoints();


app.Run();
