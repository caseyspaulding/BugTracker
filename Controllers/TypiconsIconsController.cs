using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TypiconsIconsController : Controller
{

    private readonly ILogger<TypiconsIconsController> _logger;

    public TypiconsIconsController(ILogger<TypiconsIconsController> logger)
    {
        _logger = logger;
    }

    [Route("/icons9")]
    public IActionResult Index()
    {
        return View();
    }
}