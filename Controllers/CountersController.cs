using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class CountersController : Controller
{

    private readonly ILogger<CountersController> _logger;

    public CountersController(ILogger<CountersController> logger)
    {
        _logger = logger;
    }

    [Route("/counters")]
    public IActionResult Index()
    {
        return View();
    }
}