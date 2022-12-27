using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class BackgroundController : Controller
{

    private readonly ILogger<BackgroundController> _logger;

    public BackgroundController(ILogger<BackgroundController> logger)
    {
        _logger = logger;
    }

    [Route("background")]
    public IActionResult Index()
    {
        return View();
    }
}