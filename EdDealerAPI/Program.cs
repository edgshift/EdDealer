using EdDealerAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<Context>(opciones=> opciones.UseSqlServer("name=defaultConnection"));

var app = builder.Build();

app.MapControllers();

app.Run();
