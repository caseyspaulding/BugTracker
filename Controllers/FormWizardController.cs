using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FormWizardController : Controller
{

    private readonly ILogger<FormWizardController> _logger;

    public FormWizardController(ILogger<FormWizardController> logger)
    {
        _logger = logger;
    }

    [Route("/form-wizard")]
    public IActionResult Index()
    {
        return View();
    }
}