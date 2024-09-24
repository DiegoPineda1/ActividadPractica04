using Actividad_Práctica_04.Data.Models;
using Actividad_Práctica_04.Data.Repositorio.Implemetacion;
using Actividad_Práctica_04.Data.Repositorio.Interfaces;
using Actividad_Práctica_04.Servicio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<db_turnosContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DefaultConnection")));

builder.Services.AddScoped<IServicioRepositori, ServicioRepositorio>();
builder.Services.AddScoped<IManeger, Manger>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
