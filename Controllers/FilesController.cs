using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FilesController : Controller
{

    private readonly ILogger<FilesController> _logger;

    public FilesController(ILogger<FilesController> logger)
    {
        _logger = logger;
    }

    [Route("/file-manager")]
    public IActionResult Index()
    {
        return View();
    }
}