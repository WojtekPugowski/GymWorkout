using GymWorkout.Infrastructure.Persistance;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
const string APP_NAME = "GymWorkout";

if (builder.Environment.IsDevelopment()) 
{
    builder.Configuration.AddJsonFile("appsettings.Development.local.json", optional: false, reloadOnChange: false);
}

// Add services to the container.
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .Enrich.WithProperty("ApplicationName", APP_NAME)
    .Enrich.WithProperty("MachineName", Environment.MachineName)
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

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