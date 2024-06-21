using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monkey.WebApi.Databases.Monkey;

namespace Monkey.WebApi.Controllers;

[ApiController]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly MonkeyDbContext _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MonkeyDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet, Route("api/v1/weatherforecast")]
    public async Task<IEnumerable<WeatherForecast>> GetAsync()
    {
        var a = await _context.TSamples.AsNoTracking().CountAsync();

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpPost, Route("api/v1/database/migrate")]
    public async Task<IActionResult> MigrateAsync()
    {
        await _context.MigrationDatabaseAsync();

        return Ok("Done");
    }
}
