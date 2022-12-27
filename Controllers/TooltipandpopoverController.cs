using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TooltipandpopoverController : Controller
{

    private readonly ILogger<TooltipandpopoverController> _logger;

    public TooltipandpopoverController(ILogger<TooltipandpopoverController> logger)
    {
        _logger = logger;
    }

    [Route("/tooltipandpopover")]
    public IActionResult Index()
    {
        return View();
    }
}