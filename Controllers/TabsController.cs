using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TabsController : Controller
{

    private readonly ILogger<TabsController> _logger;

    public TabsController(ILogger<TabsController> logger)
    {
        _logger = logger;
    }

    [Route("/tabs")]
    public IActionResult Index()
    {
        return View();
    }
}