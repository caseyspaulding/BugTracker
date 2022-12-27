using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class MapelMapsController : Controller
{

    private readonly ILogger<MapelMapsController> _logger;

    public MapelMapsController(ILogger<MapelMapsController> logger)
    {
        _logger = logger;
    }

    [Route("/maps2")]
    public IActionResult Index()
    {
        return View();
    }
}