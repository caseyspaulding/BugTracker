using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class PositionController : Controller
{

    private readonly ILogger<PositionController> _logger;

    public PositionController(ILogger<PositionController> logger)
    {
        _logger = logger;
    }

    [Route("/position")]
    public IActionResult Index()
    {
        return View();
    }
}