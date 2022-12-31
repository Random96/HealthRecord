using Microsoft.Extensions.DependencyInjection;
using ru.emlsoft.data;
using ru.emlsoft.data.ef;
using ru.emlsoft.data.ef.Repository;
using ru.emlsoft.health.model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ModelProfile));

var connectionString = builder.Configuration.GetConnectionString("HealthDb");
ru.emlsoft.health.model.Register.RegisterBase(builder.Services, connectionString);
ru.emlsoft.data.ef.Register.RegisterBase(builder.Services);

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
