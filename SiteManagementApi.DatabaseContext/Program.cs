using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SiteManagementApi.Data.Context;
using SiteManagementApi.DatabaseContext.Context;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SSOContext>(option => option.UseSqlServer(configuration.GetConnectionString("SSOUserDB"),
                                                                                o => o.MigrationsHistoryTable(
                                                                                    tableName: HistoryRepository.DefaultTableName,
                                                                                    schema: "SSO")));
builder.Services.AddDbContext<DashboardContext>(option => option.UseSqlServer(configuration.GetConnectionString("DashboardDB"),
                                                                                o=> o.MigrationsHistoryTable(
                                                                                    tableName:HistoryRepository.DefaultTableName,
                                                                                    schema:"DASH")));

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
