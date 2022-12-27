using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class EmptyPageController : Controller
{

    private readonly ILogger<EmptyPageController> _logger;

    public EmptyPageController(ILogger<EmptyPageController> logger)
    {
        _logger = logger;
    }

    [Route("/empty")]
    public IActionResult Index()
    {
        return View();
    }
}