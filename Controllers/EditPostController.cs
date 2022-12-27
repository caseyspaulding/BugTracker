using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class EditPostController : Controller
{

    private readonly ILogger<EditPostController> _logger;

    public EditPostController(ILogger<EditPostController> logger)
    {
        _logger = logger;
    }

    [Route("/blog-edit")]
    public IActionResult Index()
    {
        return View();
    }
}