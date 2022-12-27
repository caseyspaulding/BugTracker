using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ServicesController : Controller
{

    private readonly ILogger<ServicesController> _logger;

    public ServicesController(ILogger<ServicesController> logger)
    {
        _logger = logger;
    }

    [Route("/services")]
    public IActionResult Index()
    {
        return View();
    }
}