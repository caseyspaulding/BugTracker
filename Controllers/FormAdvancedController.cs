using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FormAdvancedController : Controller
{

    private readonly ILogger<FormAdvancedController> _logger;

    public FormAdvancedController(ILogger<FormAdvancedController> logger)
    {
        _logger = logger;
    }

    [Route("/form-advanced")]
    public IActionResult Index()
    {
        return View();
    }
}