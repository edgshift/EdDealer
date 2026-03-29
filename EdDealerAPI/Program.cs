using EdDealerAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(opciones=> opciones.UseSqlServer());


var app = builder.Build();

app.MapControllers();

app.Run();
