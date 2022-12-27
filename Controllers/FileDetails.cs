using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FileDetails : Controller
{

    private readonly ILogger<FileDetails> _logger;

    public FileDetails(ILogger<FileDetails> logger)
    {
        _logger = logger;
    }

    [Route("/file-manager-2")]
    public IActionResult Index()
    {
        return View();
    }
}