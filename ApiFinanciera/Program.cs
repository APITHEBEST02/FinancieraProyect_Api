

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


//EndPoint de credito
builder.Services.AddScoped<OCredito>(provider=>new RCredito(connectionString));
builder.Services.AddScoped<ICredito, SCredito>();

//EndPoint de credito calendario Det
builder.Services.AddScoped<OCreditoCalendarioDet>(provider=>new RCreditoCalendarioDet(connectionString));
builder.Services.AddScoped<ICreditoCalendarioDet,SCreditoCalendarioDet>();

//EndPoint de Almacen
builder.Services.AddScoped<OAlmacen>(provider => new RAlmacen(connectionString));
builder.Services.AddScoped<IAlmacen, SAlmacen>();

//EndPoint ConfigProducto
builder.Services.AddScoped<OConfigProducto>(provider => new RConfigProducto(connectionString));
builder.Services.AddScoped<IConfigProducto, SConfigProducto>();

//EndPoint Persona
builder.Services.AddScoped<OPersona>(provider => new RPersona(connectionString));
builder.Services.AddScoped<IPersona, SPersona>();

//EndPoint ProductoCredito
builder.Services.AddScoped<OProductoCredito>(provider => new RProductoCredito(connectionString));
builder.Services.AddScoped<IProductoCredito, SProductoCredito>();

//EndPoint Sede
builder.Services.AddScoped<OSede>(provider => new RSede(connectionString));
builder.Services.AddScoped<ISede,SSede>();

//EndPoint Tipo Contrato
builder.Services.AddScoped<OTipoContratoCredito>(provider=>new RTipoContratoCredito(connectionString));
builder.Services.AddScoped<ITipoContratoCredito, STipoContrato>();

//EndPoint Tipo Garantia
builder.Services.AddScoped<OTipoContratoGarantiaCredito>(provider => new RTipoContratoGarantia(connectionString));
builder.Services.AddScoped<ITipoContratoGarantiaCredito, STipoGarantia>();

//EndPoint Tipo persona
builder.Services.AddScoped<OTipoPersona>(provider => new RTipoPersona(connectionString));
builder.Services.AddScoped<ITipoPersona, STipoPersona>();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy => policy.WithOrigins("http://localhost:4200", "https://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials());
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Financiera - Arquitectura Hexagonal", Version = "v1" });
});


var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

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
