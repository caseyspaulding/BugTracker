using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TimelineController : Controller
{

    private readonly ILogger<TimelineController> _logger;

    public TimelineController(ILogger<TimelineController> logger)
    {
        _logger = logger;
    }

    [Route("/timeline")]
    public IActionResult Index()
    {
        return View();
    }
}