using Microsoft.EntityFrameworkCore;
using SiteManagementApi.Data.Context;
using SiteManagementApi.DatabaseContext.Context;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SSOContext>(option => option.UseSqlServer(configuration.GetConnectionString("SSOUserDB")));
builder.Services.AddDbContext<DashboardContext>(option => option.UseSqlServer(configuration.GetConnectionString("DashboardDB")));

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
