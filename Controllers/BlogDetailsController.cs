using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class BlogDetailsController : Controller
{

    private readonly ILogger<BlogDetailsController> _logger;

    public BlogDetailsController(ILogger<BlogDetailsController> logger)
    {
        _logger = logger;
    }

    [Route("/blog-details")]
    public IActionResult Index()
    {
        return View();
    }
}