using Microsoft.AspNetCore.Mvc;

[Area("Help")]
public class TutorialController : Controller
{
  public IActionResult Index(int id)
  {
    switch (id)
    {
      case 1:
        return View("Page1");
      case 2:
        return View("Page2");
      case 3:
        return View("Page3");
      default:
        return RedirectToAction("Index", "Home");
    }
  }
}