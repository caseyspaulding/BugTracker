using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class AlertsController : Controller
{

    private readonly ILogger<AlertsController> _logger;

    public AlertsController(ILogger<AlertsController> logger)
    {
        _logger = logger;
    }

    [Route("/alerts")]
    public IActionResult Index()
    {
        return View();
    }
}