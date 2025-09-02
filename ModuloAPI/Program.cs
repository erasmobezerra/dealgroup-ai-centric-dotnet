using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


// adicionar suporte a controllers MVC
builder.Services.AddControllers();

// adicionar suporte a Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline for development
if (app.Environment.IsDevelopment())
{
    // OpenApi
    // Interface: http://localhost:5137/openapi/v1.json
    app.MapOpenApi();

    // Swagger
    // Interface: http://localhost:5137/swagger/index.html
    // Learn more about configuring SwaggerUI at https://swagger.io/tools/swagger-ui/
    app.UseSwagger();
    app.UseSwaggerUI();

    // Scalar
    // Interface: http://localhost:5137/scalar/v1
    // Learn more about configuring Scalar at https://guides.scalar.com/scalar/introduction
    app.MapScalarApiReference();
}


app.UseHttpsRedirection();

// Mapeia endpoints dos controllers
app.MapControllers();

// ...existing code...
await app.RunAsync();
