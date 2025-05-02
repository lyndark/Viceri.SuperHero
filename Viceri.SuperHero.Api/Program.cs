using Microsoft.EntityFrameworkCore;
using Viceri.SuperHero.Api.Infrastructure;
using Viceri.SuperHero.Api.Interface;
using Viceri.SuperHero.Api.Repository;
using Viceri.SuperHero.Api.Service;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string dbPath = Path.Combine(Environment.CurrentDirectory, "superhero.db");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source = {dbPath}"));

builder.Services.AddScoped<IHeroRepository, HeroRepository>();
builder.Services.AddScoped<IPowerRepository, PowerRepository>();

builder.Services.AddScoped<IHeroService, HeroService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();

var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();


dbContext.Database.EnsureCreated();

app.Run();
