using Microsoft.AspNetCore.Mvc;

[Area("Help")]
public class HomeController : Controller
{

    [Route("Help/topic/{topic}/category/{category}")] // Matches /topic/anything/category/anything
    [Route("Help/category/{category}")] // Matches /category/anything
    [Route("Help/topic/{topic}")] // Matches /topic/anything
    [Route("Help")] // This is the default route
    public IActionResult Index(string? topic = null, string? category = null)
    {
        

        return View();
    }

    // [Route("Help/Tutorial/{id?}")]
    // public IActionResult Tutorial(int id = 1)
    // {
    //     return View();
    // }
}