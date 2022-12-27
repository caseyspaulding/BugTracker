using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class SettingsController : Controller
{

    private readonly ILogger<SettingsController> _logger;

    public SettingsController(ILogger<SettingsController> logger)
    {
        _logger = logger;
    }

    [Route("/settings")]
    public IActionResult Index()
    {
        return View();
    }
}