using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FormLayoutsController : Controller
{

    private readonly ILogger<FormLayoutsController> _logger;

    public FormLayoutsController(ILogger<FormLayoutsController> logger)
    {
        _logger = logger;
    }

    [Route("/form-layouts")]
    public IActionResult Index()
    {
        return View();
    }
}