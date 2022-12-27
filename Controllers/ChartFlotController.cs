using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ChartFlotController : Controller
{

    private readonly ILogger<ChartFlotController> _logger;

    public ChartFlotController(ILogger<ChartFlotController> logger)
    {
        _logger = logger;
    }

    [Route("/chart-flot")]
    public IActionResult Index()
    {
        return View();
    }
}