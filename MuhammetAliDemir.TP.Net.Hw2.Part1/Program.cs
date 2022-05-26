using MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples;
using MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


//Adding the CoffeeMaker Implementations
builder.Services.AddScoped<IWhiteChocoCoffeeMaker, BitterWhiteChocoMaker>();
//builder.Services.AddScoped<IWhiteChocoCoffeeMaker, SweetWhiteChocoMaker>();


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
