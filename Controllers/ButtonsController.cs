using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ButtonsController : Controller
{

    private readonly ILogger<ButtonsController> _logger;

    public ButtonsController(ILogger<ButtonsController> logger)
    {
        _logger = logger;
    }

    [Route("/buttons")]
    public IActionResult Index()
    {
        return View();
    }
}