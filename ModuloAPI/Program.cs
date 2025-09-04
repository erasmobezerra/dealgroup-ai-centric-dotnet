using Microsoft.EntityFrameworkCore;
using ModuloAPI.Context;
using Scalar.AspNetCore;

// Cria o builder da aplicação web, que configura os serviços e o pipeline de execução
var builder = WebApplication.CreateBuilder(args);

// 🔧 Adiciona serviços ao contêiner de injeção de dependência para que possam ser 
//    injetados em controllers e services

//  Registra o AgendaContext no sistema de injeção de dependência da aplicação e configura o EF Core para 
//  usar o SQL Server como banco de dados, utilizando a string de conexão chamada "ConexaoPadrao" definida no appsettings.json.
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Adiciona suporte ao OpenAPI, que permite gerar documentação da API em formato JSON
builder.Services.AddOpenApi();
// Adiciona suporte ao Swagger, que gera uma interface gráfica para testar e explorar a API
builder.Services.AddEndpointsApiExplorer(); // Necessário para expor os endpoints no Swagger
builder.Services.AddSwaggerGen();           // Gera a documentação Swagger com base nos controllers

// adicionar suporte a controllers MVC, que permitem organizar endpoints em classes
builder.Services.AddControllers();

// 🔨 Constrói a aplicação com base nas configurações feitas acima
var app = builder.Build();

// 🌐 Configura o pipeline de requisições HTTP (middleware) para ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // Mapeia o endpoint do OpenAPI (documentação em JSON da API)
    // Acesse por : http://localhost:5137/openapi/v1.json
    app.MapOpenApi();

    // Ativa o middleware do Swagger para gerar a documentação interativa
    // Acesse por:  http://localhost:5137/swagger/index.html
    app.UseSwagger();      // Gera o JSON da documentação
    app.UseSwaggerUI();    // Interface gráfica para explorar os endpoints

    // Mapeia o endpoint do Scalar, que fornece uma referência interativa da API
    //  Acesse por:  http://localhost:5137/scalar/v1
    app.MapScalarApiReference();

}

// 🔒 Adiciona middleware ára redirecionar automaticamente requisições HTTP para HTTPS
app.UseHttpsRedirection();

// 🚀 Mapeia os endpoints definidos nos controllers que usam roteamento baseado em atributos como [HttpGet], [HttpPost], [Route("api/alguma-coisa")], etc.
app.MapControllers();

// 🏁 Inicia a aplicação e começa a escutar requisições
app.Run();