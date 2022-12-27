using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class SweetAlertsController : Controller
{

    private readonly ILogger<SweetAlertsController> _logger;

    public SweetAlertsController(ILogger<SweetAlertsController> logger)
    {
        _logger = logger;
    }

    [Route("/sweetalerts")]
    public IActionResult Index()
    {
        return View();
    }
}