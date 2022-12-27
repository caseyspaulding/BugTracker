using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class SimpleIconsController : Controller
{

    private readonly ILogger<SimpleIconsController> _logger;

    public SimpleIconsController(ILogger<SimpleIconsController> logger)
    {
        _logger = logger;
    }

    [Route("/icons3")]
    public IActionResult Index()
    {
        return View();
    }
}