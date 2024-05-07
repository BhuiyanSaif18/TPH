using Microsoft.AspNetCore.Mvc;

namespace TPH.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}

// public class User
// {
//     public int UserId { get; set; }
//     public string UserName { get; set; }
//     public UserProfile Profile { get; set; } // Navigation property for one-to-one relationship
// }
//
// public class UserProfile
// {
//     public int UserProfileId { get; set; }
//     public string FullName { get; set; }
//     public User User { get; set; } // Navigation property for one-to-one relationship
// }
//
// public class YourDbContext : DbContext
// {
//     public DbSet<User> Users { get; set; }
//     public DbSet<UserProfile> Profiles { get; set; }
//
//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         // Configure your database connection here
//         optionsBuilder.UseSqlServer("your_connection_string_here");
//     }
// }