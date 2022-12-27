using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class WeatherIconsController : Controller
{

    private readonly ILogger<WeatherIconsController> _logger;

    public WeatherIconsController(ILogger<WeatherIconsController> logger)
    {
        _logger = logger;
    }

    [Route("/icons10")]
    public IActionResult Index()
    {
        return View();
    }
}