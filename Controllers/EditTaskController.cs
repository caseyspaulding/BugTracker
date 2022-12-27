using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class EditTaskController : Controller
{

    private readonly ILogger<EditTaskController> _logger;

    public EditTaskController(ILogger<EditTaskController> logger)
    {
        _logger = logger;
    }

    [Route("/tasks-edit")]
    public IActionResult Index()
    {
        return View();
    }
}