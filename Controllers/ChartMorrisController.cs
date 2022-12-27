using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ChartMorrisController : Controller
{

    private readonly ILogger<ChartMorrisController> _logger;

    public ChartMorrisController(ILogger<ChartMorrisController> logger)
    {
        _logger = logger;
    }

    [Route("/chart-morris")]
    public IActionResult Index()
    {
        return View();
    }
}