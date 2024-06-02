using Bridal.Core;
using Bridal.Core.Repositories;
using Bridal.Core.Services;
using Bridal.Data;
using Bridal.Data.Repositories;
using Bridal.Service;
using BridalSalon;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBridalRepository, BridalRepository>();
builder.Services.AddScoped<IBridalService, BridalService>();
builder.Services.AddScoped<IDressmakerRepository, DressmakerRepository>();
builder.Services.AddScoped<IDressmakerService, DressmakerService>();
builder.Services.AddScoped<IQueueBridalRepository, QueueBridalRepository>();
builder.Services.AddScoped<IQueueBridalService, QueueBridalService>();

builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddAutoMapper(typeof(Mapping));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ShabbatMiddleware>();

app.MapControllers();

app.Run();
