using Microsoft.AspNetCore.Mvc;

[Area("Help")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}