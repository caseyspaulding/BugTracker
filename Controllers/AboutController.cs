using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class AboutController : Controller
{

    private readonly ILogger<AboutController> _logger;

    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;
    }

    [Route("/about")]
    public IActionResult Index()
    {
        return View();
    }
}