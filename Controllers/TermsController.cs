using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class TermsController : Controller
{

    private readonly ILogger<TermsController> _logger;

    public TermsController(ILogger<TermsController> logger)
    {
        _logger = logger;
    }

    [Route("/terms")]
    public IActionResult Index()
    {
        return View();
    }
}