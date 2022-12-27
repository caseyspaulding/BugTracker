using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class CartController : Controller
{

    private readonly ILogger<CartController> _logger;

    public CartController(ILogger<CartController> logger)
    {
        _logger = logger;
    }

    [Route("/cart")]
    public IActionResult Index()
    {
        return View();
    }
}