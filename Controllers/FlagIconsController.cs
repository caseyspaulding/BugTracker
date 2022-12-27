using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FlagIconsController : Controller
{

    private readonly ILogger<FlagIconsController> _logger;

    public FlagIconsController(ILogger<FlagIconsController> logger)
    {
        _logger = logger;
    }

    [Route("/icons6")]
    public IActionResult Index()
    {
        return View();
    }
}