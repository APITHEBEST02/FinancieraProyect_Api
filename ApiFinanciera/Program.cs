

using Application.Banca;
using Application.Configuracion;
using Domain.Interfaces.Input.Configuracion;
using Domain.Interfaces.Output.Banca;
using Domain.Interfaces.Output.Configuracion;
using Infrastructure.Repositorio.Banca;
using Infrastructure.Repositorio.Configuracion;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("sqlConnetion");

builder.Services.AddScoped<OCredito>(provider=>new RCredito(connectionString));
builder.Services.AddScoped<ICredito, SCredito>();

builder.Services.AddScoped<OCreditoCalendarioDet>(provider=>new RCreditoCalendarioDet(connectionString));
builder.Services.AddScoped<ICreditoCalendarioDet,SCreditoCalendarioDet>();

builder.Services.AddScoped<OAlmacen>(provider => new RAlmacen(connectionString));
builder.Services.AddScoped<IAlmacen, SAlmacen>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Financiera - Arquitectura Hexagonal", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Financiera - Arquitectura Hexagonal v1"));
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();
