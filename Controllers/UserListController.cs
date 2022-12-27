using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class UserListController : Controller
{

    private readonly ILogger<UserListController> _logger;

    public UserListController(ILogger<UserListController> logger)
    {
        _logger = logger;
    }

    [Route("/user-list")]
    public IActionResult Index()
    {
        return View();
    }
}