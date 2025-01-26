using Microsoft.EntityFrameworkCore;
using Store.Application.Interfaces;
using Store.Application.Services;
using Store.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer("Data Source=DESKTOP-GN4H313\\TECHNOTO;Initial Catalog=StoreDbContext;User Id=sa;Password=Am@13802;MultipleActiveResultSets=True;TrustServerCertificate=True;"));

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
