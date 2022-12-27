using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class LandingPageController : Controller
{

    private readonly ILogger<LandingPageController> _logger;

    public LandingPageController(ILogger<LandingPageController> logger)
    {
        _logger = logger;
    }

    [Route("/landingpage")]
    public IActionResult Index()
    {
        return View();
    }
}