using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class DropdownController : Controller
{

    private readonly ILogger<DropdownController> _logger;

    public DropdownController(ILogger<DropdownController> logger)
    {
        _logger = logger;
    }

    [Route("/dropdown")]
    public IActionResult Index()
    {
        return View();
    }
}