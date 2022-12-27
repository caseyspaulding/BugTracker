using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ModalsController : Controller
{

    private readonly ILogger<ModalsController> _logger;

    public ModalsController(ILogger<ModalsController> logger)
    {
        _logger = logger;
    }

    [Route("/modals")]
    public IActionResult Index()
    {
        return View();
    }
}