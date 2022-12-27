using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class HeightController : Controller
{

    private readonly ILogger<HeightController> _logger;

    public HeightController(ILogger<HeightController> logger)
    {
        _logger = logger;
    }

    [Route("/height")]
    public IActionResult Index()
    {
        return View();
    }
}