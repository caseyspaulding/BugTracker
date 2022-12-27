using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ThumbnailsController : Controller
{

    private readonly ILogger<ThumbnailsController> _logger;

    public ThumbnailsController(ILogger<ThumbnailsController> logger)
    {
        _logger = logger;
    }

    [Route("/thumbnails")]
    public IActionResult Index()
    {
        return View();
    }
}