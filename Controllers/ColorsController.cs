using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ColorsController : Controller
{

    private readonly ILogger<ColorsController> _logger;

    public ColorsController(ILogger<ColorsController> logger)
    {
        _logger = logger;
    }

    [Route("/colors")]
    public IActionResult Index()
    {
        return View();
    }
}