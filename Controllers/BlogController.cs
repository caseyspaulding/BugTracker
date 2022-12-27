using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class BlogController : Controller
{

    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger)
    {
        _logger = logger;
    }

    [Route("/blog")]
    public IActionResult Index()
    {
        return View();
    }
}