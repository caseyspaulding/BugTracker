using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class BadgesController : Controller
{

    private readonly ILogger<BadgesController> _logger;

    public BadgesController(ILogger<BadgesController> logger)
    {
        _logger = logger;
    }

    [Route("/badge")]
    public IActionResult Index()
    {
        return View();
    }
}