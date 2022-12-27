using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class AvatarController : Controller
{

    private readonly ILogger<AvatarController> _logger;

    public AvatarController(ILogger<AvatarController> logger)
    {
        _logger = logger;
    }

    [Route("/avatar")]
    public IActionResult Index()
    {
        return View();
    }
}