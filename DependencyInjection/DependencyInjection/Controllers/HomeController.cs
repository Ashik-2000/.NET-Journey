using DependencyInjection.Services.Cities;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers;

[Route("api")]
public class HomeController : Controller
{
    private readonly IcitiesServices _citiesService;

    public HomeController(IcitiesServices citiesSerivces)
    {
        _citiesService = citiesSerivces;
    }

    [HttpGet("Cities")]
    public IActionResult GetData()
    {
        var result = _citiesService.GetCities();
        return Ok(result);
    }
}
