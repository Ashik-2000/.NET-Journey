using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWorkCore.Controllers;

public class CountyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
