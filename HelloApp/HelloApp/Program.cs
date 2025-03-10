

using BusinessLayer.Service;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString =
builder.Configuration.GetConnectionString("SQLConnection");
builder.Services.AddDbContext<HelloAppContext>(options  => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();
builder.Services.AddSwaggerGen();


var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();

app.MapControllers();

app.Run();
