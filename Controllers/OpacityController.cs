using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class OpacityController : Controller
{

    private readonly ILogger<OpacityController> _logger;

    public OpacityController(ILogger<OpacityController> logger)
    {
        _logger = logger;
    }

    [Route("/opacity")]
    public IActionResult Index()
    {
        return View();
    }
}