using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class LoaderController : Controller
{

    private readonly ILogger<LoaderController> _logger;

    public LoaderController(ILogger<LoaderController> logger)
    {
        _logger = logger;
    }

    [Route("/loaders")]
    public IActionResult Index()
    {
        return View();
    }
}