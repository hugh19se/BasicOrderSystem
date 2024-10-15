using BasicOrderSystem.WebAPI.DataAccess;
using BasicOrderSystem.WebAPI.Interfaces.DataAccess;
using BasicOrderSystem.WebAPI.Interfaces.Repositories;
using BasicOrderSystem.WebAPI.Interfaces.Services;
using BasicOrderSystem.WebAPI.Options;
using BasicOrderSystem.WebAPI.Repositories;
using BasicOrderSystem.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

//Add Controllers
builder.Services.AddControllers();

//Add Options
builder.Services.Configure<JSONOrderRetrieverOptions>(builder.Configuration.GetSection(JSONOrderRetrieverOptions.ConfigBinding));
builder.Services.Configure<OrderDBOptions>(builder.Configuration.GetSection(OrderDBOptions.ConfigBinding));

//Add Services
/*
IOrderRetriever uses JSONOrderRetriever to simulate db calls as I can't reasonably host a SQL Server instance for this project
If you want to test the SQL Server capability in SQLServerOrderRetriever, follow the guide in the repo wiki to set up and configure your own instance.
 */
builder.Services.AddTransient<IOrderRetriever, JSONOrderRetriever>();//Can change from JSON to OrderDB here
builder.Services.AddTransient<IConnectionStringBuilder, ConnectionStringBuilder>();

//Add Data Access
builder.Services.AddSingleton<IOrderDBRepositoryDataAccess, OrderDBRepositoryDataAccess>();

//Add Repositories
builder.Services.AddTransient<IOrderDBRepository, OrderDBRepository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
