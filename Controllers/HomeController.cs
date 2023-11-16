using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace tess_thomas_dotnetapp.Controllers;

[Route("")] // This is the default route, so we can omit it
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // Should not need these actions for the app
    // Deleted related boilerplate files: Views/Home/Privacy.cshtml, Views/Shared/Error.cshtml, Models/ErrorViewModel.cs
    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}
