using Microsoft.EntityFrameworkCore;
using Project.Infrastructure.Persistence;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbcontext>(opitons =>
{
    opitons.UseSqlite(builder.Configuration.GetConnectionString("DefaultConneciton"));

});

builder.Services.AddOpenApi();

var app = builder.Build();


if(app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


var summaries = new[]
{
    "Freezing" , "Bracing" , "Chilly" , "Coll" , "Mild" , "Warm" , "Balmy" , "Hot" , "Sweltring" , "Scorching"
};

app.MapGet("/Weatherforecast" , () =>
{
    var forecast = Enumerable.Range(1 , 5).Select(index =>
    new WeatherForecast
    (
        DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        Random.Shared.Next(-20 , 55),
        summaries[Random.Shared.Next(summaries.Length)]
    ))
    .ToArray();
    return forecast;

    
})
.WithName("GetweatherForecast");
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
