using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class CardsController : Controller
{

    private readonly ILogger<CardsController> _logger;

    public CardsController(ILogger<CardsController> logger)
    {
        _logger = logger;
    }

    [Route("/cards")]
    public IActionResult Index()
    {
        return View();
    }
}