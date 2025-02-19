using Frutaria.LINQ;
using Frutaria.LINQ.Interfaces;
using Frutaria.LINQ.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IFrutaService, FrutaService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseInMemoryDatabase("FrutariaDb");
});

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
