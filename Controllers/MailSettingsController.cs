using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class MailSettingsController : Controller
{

    private readonly ILogger<MailSettingsController> _logger;

    public MailSettingsController(ILogger<MailSettingsController> logger)
    {
        _logger = logger;
    }

    [Route("/mail-settings")]
    public IActionResult Index()
    {
        return View();
    }
}