using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TagsController : Controller
{

    private readonly ILogger<TagsController> _logger;

    public TagsController(ILogger<TagsController> logger)
    {
        _logger = logger;
    }


    [Route("/tags")]
    public IActionResult Index()
    {
        return View();
    }
}