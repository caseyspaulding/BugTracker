using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TablesController : Controller
{

    private readonly ILogger<TablesController> _logger;

    public TablesController(ILogger<TablesController> logger)
    {
        _logger = logger;
    }

    [Route("/tables")]
    public IActionResult Index()
    {
        return View();
    }
}