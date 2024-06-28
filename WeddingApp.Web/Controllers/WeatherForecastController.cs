using Microsoft.AspNetCore.Mvc;
using WeddingApp.BusinessLogic.Repository.Interface;

namespace WeddingApp.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly IItemTypeRepository _itemTypeRepository;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IItemTypeRepository itemTypeRepository,ILogger<WeatherForecastController> logger)
    {
        _itemTypeRepository = itemTypeRepository;
        _logger = logger;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
        return Ok(result);
    }
    [HttpGet]
    [Route("GetItemType")]
    public IActionResult GetItemType()
    {
        return Ok(_itemTypeRepository.GetAll());
    }
}
