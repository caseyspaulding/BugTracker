using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ChartNvd3Controller : Controller
{

    private readonly ILogger<ChartNvd3Controller> _logger;

    public ChartNvd3Controller(ILogger<ChartNvd3Controller> logger)
    {
        _logger = logger;
    }

    [Route("/chart-nvd3")]
    public IActionResult Index()
    {
        return View();
    }
}