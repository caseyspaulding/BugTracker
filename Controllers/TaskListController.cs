using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TaskListController : Controller
{

    private readonly ILogger<TaskListController> _logger;

    public TaskListController(ILogger<TaskListController> logger)
    {
        _logger = logger;
    }

    [Route("/tasks-list")]
    public IActionResult Index()
    {
        return View();
    }
}