using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class CreateInvoiceController : Controller
{

    private readonly ILogger<CreateInvoiceController> _logger;

    public CreateInvoiceController(ILogger<CreateInvoiceController> logger)
    {
        _logger = logger;
    }

    [Route("/invoice-create")]
    public IActionResult Index()
    {
        return View();
    }
}