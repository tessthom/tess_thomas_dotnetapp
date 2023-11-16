using Microsoft.AspNetCore.Mvc;

[Area("Help")]
public class HomeController : Controller
{
    public IActionResult Index(string topic, string category)
    {
        // Get all FAQs from FaqData.cs
        var faqs = FaqData.AllFaqs;

        // Store FAQs in ViewData
        ViewData["faqs"] = faqs;

        return View();
    }
}