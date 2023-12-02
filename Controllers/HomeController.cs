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
        // My contact data
        var contactData = new Dictionary<string, string>
        {
            { "Name", "Tess Thomas"},
            { "Creds", "Full-Stack Web Developer" },
            { "Email", "abthomas3@my.waketech.edu" },
            { "Phone", "843-555-5555" },
            { "LinkedIn", "https://www.linkedin.com/in/tess-thomas-dev/" },
            { "GitHub", "https://github.com/tessthom" }
        };

        // Pass the data to the view
        return View(contactData);
    }

    [HttpPost]
    public IActionResult SubmitForm(string name, string email, string message)
    {
        if (string.IsNullOrEmpty(name))
        {
            TempData["NameError"] = "Name is required.";
        }
        if (string.IsNullOrEmpty(email))
        {
            TempData["EmailError"] = "Email is required.";
        }
        if (string.IsNullOrEmpty(message)) 
        {
            TempData["MessageError"] = "Comment is required.";
        }

        if (ViewData["NameError"] == null && ViewData["EmailError"] == null && ViewData["MessageError"] == null)
        {
            TempData["SuccessMessage"] = "Thank you for your feedback!";
        }

        return RedirectToAction("Contact");
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
