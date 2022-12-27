using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ChartChartJsController : Controller
{

    private readonly ILogger<ChartChartJsController> _logger;

    public ChartChartJsController(ILogger<ChartChartJsController> logger)
    {
        _logger = logger;
    }

    [Route("/chart-chartjs")]
    public IActionResult Index()
    {
        return View();
    }
}