using Microsoft.Extensions.DependencyInjection;
using ru.emlsoft.data;
using ru.emlsoft.data.domain;
using ru.emlsoft.data.Repository;
using ru.emlsoft.health.model;

Func<IServiceProvider, IDataModel> factoryDb = null!;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("HealthDb");
factoryDb = x => new DataModel(connectionString, x.GetRequiredService<ILogger<DataModel>>());


builder.Services.AddScoped(typeof(IRepository<,>),typeof(Repository<,>));
builder.Services.AddScoped(typeof(IDataModel), factoryDb);
builder.Services.AddAutoMapper(typeof(ModelProfile));


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
