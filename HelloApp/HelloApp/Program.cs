

using BusinessLayer.Service;
using RepositoryLayer.Service;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();



var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
