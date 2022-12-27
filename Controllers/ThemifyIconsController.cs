using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ThemifyIconsController : Controller
{

    private readonly ILogger<ThemifyIconsController> _logger;

    public ThemifyIconsController(ILogger<ThemifyIconsController> logger)
    {
        _logger = logger;
    }

    [Route("/icons8")]
    public IActionResult Index()
    {
        return View();
    }
}