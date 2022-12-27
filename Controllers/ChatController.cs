using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ChatController : Controller
{

    private readonly ILogger<ChatController> _logger;

    public ChatController(ILogger<ChatController> logger)
    {
        _logger = logger;
    }

    [Route("/chat")]
    public IActionResult Index()
    {
        return View();
    }
}