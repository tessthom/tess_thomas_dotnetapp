using Microsoft.AspNetCore.Mvc;

[Area("Help")]
public class TutorialController : Controller
{
  public IActionResult Page1()
  {
    return View();
  }

  public IActionResult Page2()
  {
    return View();
  }

  public IActionResult Page3()
  {
    return View();
  }
}