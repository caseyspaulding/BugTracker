using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FontAwesomeController : Controller
{

    private readonly ILogger<FontAwesomeController> _logger;

    public FontAwesomeController(ILogger<FontAwesomeController> logger)
    {
        _logger = logger;
    }

    [Route("/icons")]
    public IActionResult Index()
    {
        return View();
    }
}