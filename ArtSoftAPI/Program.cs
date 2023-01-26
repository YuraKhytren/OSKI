using ArtSoftAPI.Service.LoggerService;
using Microsoft.EntityFrameworkCore;
using ArtSoftAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<LoggerService>();
var con = builder.Configuration.GetConnectionString("ConnString");

builder.Services.AddDbContext<ArtSoftAPI.Data.AppContext>(options => options.UseSqlServer(con),ServiceLifetime.Transient);
builder.Services.AddTransient<AppRepository>();
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
