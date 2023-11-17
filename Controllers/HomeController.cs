using Microsoft.AspNetCore.Mvc;

namespace tess_thomas_dotnetapp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Attribute based routing
    [Route("topic/{topic}/category/{category}")] // Matches /topic/anything/category/anything
    [Route("category/{category}")] // Matches /category/anything
    [Route("topic/{topic}")] // Matches /topic/anything
    [Route("")] // This is the default route
    public IActionResult Index(string? topic = null, string? category = null)
    {
        // logic for the home page goes here
        
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
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
