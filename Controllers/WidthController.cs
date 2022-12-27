using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class WidthController : Controller
{

    private readonly ILogger<WidthController> _logger;

    public WidthController(ILogger<WidthController> logger)
    {
        _logger = logger;
    }


    [Route("/width")]
    public IActionResult Index()
    {
        return View();
    }
}