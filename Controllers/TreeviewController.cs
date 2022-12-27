using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TreeviewController : Controller
{

    private readonly ILogger<TreeviewController> _logger;

    public TreeviewController(ILogger<TreeviewController> logger)
    {
        _logger = logger;
    }

    [Route("/treeview")]
    public IActionResult Index()
    {
        return View();
    }
}