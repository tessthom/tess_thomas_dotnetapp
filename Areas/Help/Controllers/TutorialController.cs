using Microsoft.AspNetCore.Mvc;

[Area("Help")]
public class TutorialController : Controller
{
  public IActionResult Index(int id)
  {
    switch (id)
    {
      case 1:
      case 2:
      case 3:
        return View("Page" + id, id);
      default:
        return RedirectToAction("Index", "Home", new { area = "Help"});
    }
  }
}