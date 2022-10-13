using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Context;
using tech_test_payment_api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ItemContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoItems")));

builder.Services.AddDbContext<VendasContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoVendas")));

builder.Services.AddDbContext<VendedoresContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoVendedores")));

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
