using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class BorderController : Controller
{

    private readonly ILogger<BorderController> _logger;

    public BorderController(ILogger<BorderController> logger)
    {
        _logger = logger;
    }

    [Route("/border")]
    public IActionResult Index()
    {
        return View();
    }
}