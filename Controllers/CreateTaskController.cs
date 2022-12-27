using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class CreateTaskController : Controller
{

    private readonly ILogger<CreateTaskController> _logger;

    public CreateTaskController(ILogger<CreateTaskController> logger)
    {
        _logger = logger;
    }

    [Route("/tasks-create")]
    public IActionResult Index()
    {
        return View();
    }
}