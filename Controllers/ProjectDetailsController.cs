using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ProjectDetailsController : Controller
{

    private readonly ILogger<ProjectDetailsController> _logger;

    public ProjectDetailsController(ILogger<ProjectDetailsController> logger)
    {
        _logger = logger;
    }

    [Route("/projects-details")]
    public IActionResult Index()
    {
        return View();
    }
}