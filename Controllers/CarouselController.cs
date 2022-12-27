using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class CarouselController : Controller
{

    private readonly ILogger<CarouselController> _logger;

    public CarouselController(ILogger<CarouselController> logger)
    {
        _logger = logger;
    }

    [Route("/carousel")]
    public IActionResult Index()
    {
        return View();
    }
}