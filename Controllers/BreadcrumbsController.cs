using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class BreadcrumbsController : Controller
{

    private readonly ILogger<BreadcrumbsController> _logger;

    public BreadcrumbsController(ILogger<BreadcrumbsController> logger)
    {
        _logger = logger;
    }

    [Route("/breadcrumbs")]
    public IActionResult Index()
    {
        return View();
    }
}