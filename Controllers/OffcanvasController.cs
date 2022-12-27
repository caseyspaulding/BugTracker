using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class OffcanvasController : Controller
{

    private readonly ILogger<OffcanvasController> _logger;

    public OffcanvasController(ILogger<OffcanvasController> logger)
    {
        _logger = logger;
    }

    [Route("/offcanvas")]
    public IActionResult Index()
    {
        return View();
    }
}