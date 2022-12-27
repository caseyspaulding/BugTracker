using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class GalleryController : Controller
{

    private readonly ILogger<GalleryController> _logger;

    public GalleryController(ILogger<GalleryController> logger)
    {
        _logger = logger;
    }

    [Route("/gallery")]
    public IActionResult Index()
    {
        return View();
    }
}