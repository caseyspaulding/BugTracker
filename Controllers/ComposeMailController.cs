using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ComposeMailController : Controller
{

    private readonly ILogger<ComposeMailController> _logger;

    public ComposeMailController(ILogger<ComposeMailController> logger)
    {
        _logger = logger;
    }

    [Route("/mail-compose")]
    public IActionResult Index()
    {
        return View();
    }
}