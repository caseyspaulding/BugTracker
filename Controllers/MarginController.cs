using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class MarginController : Controller
{

    private readonly ILogger<MarginController> _logger;

    public MarginController(ILogger<MarginController> logger)
    {
        _logger = logger;
    }

    [Route("/margin")]
    public IActionResult Index()
    {
        return View();
    }
}