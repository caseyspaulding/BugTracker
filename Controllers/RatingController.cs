using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class RatingController : Controller
{

    private readonly ILogger<RatingController> _logger;

    public RatingController(ILogger<RatingController> logger)
    {
        _logger = logger;
    }

    [Route("/rating")]
    public IActionResult Index()
    {
        return View();
    }
}