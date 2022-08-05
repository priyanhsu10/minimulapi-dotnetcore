using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using minialapi2;
using minialapi2.Interfaces;
using minialapi2.Repositories;
using minialapi2.Requests;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediatR(r => r.AsScoped(),typeof(Program));
builder.Services.AddDbContext<TodoCotext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("postgres"));
});
var app = builder.Build();

app.RegisterTodoRoutes();

app.Run();


