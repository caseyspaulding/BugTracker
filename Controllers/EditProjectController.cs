using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class EditProjectController : Controller
{

    private readonly ILogger<EditProjectController> _logger;

    public EditProjectController(ILogger<EditProjectController> logger)
    {
        _logger = logger;
    }

    [Route("/projects-edit")]
    public IActionResult Index()
    {
        return View();
    }
}