using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class InvoiceDetailsController : Controller
{

    private readonly ILogger<InvoiceDetailsController> _logger;

    public InvoiceDetailsController(ILogger<InvoiceDetailsController> logger)
    {
        _logger = logger;
    }

    [Route("/invoice-details")]
    public IActionResult Index()
    {
        return View();
    }
}