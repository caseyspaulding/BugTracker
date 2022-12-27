using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class WishlistController : Controller
{

    private readonly ILogger<WishlistController> _logger;

    public WishlistController(ILogger<WishlistController> logger)
    {
        _logger = logger;
    }

    [Route("/wishlist")]
    public IActionResult Index()
    {
        return View();
    }
}