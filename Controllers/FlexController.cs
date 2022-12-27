using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FlexController : Controller
{

    private readonly ILogger<FlexController> _logger;

    public FlexController(ILogger<FlexController> logger)
    {
        _logger = logger;
    }

    [Route("/flex")]
    public IActionResult Index()
    {
        return View();
    }
}