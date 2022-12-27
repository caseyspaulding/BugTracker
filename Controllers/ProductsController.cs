using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ProductsController : Controller
{

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [Route("/products")]
    public IActionResult Index()
    {
        return View();
    }
}