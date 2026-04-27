using Alor.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Alor.Web.Controllers;

public sealed class HomeController(IWorldMapService worldMapService) : Controller
{
    public IActionResult Index()
    {
        var world = worldMapService.GetWorld();
        return View(world);
    }

    [HttpGet("api/world")]
    public IActionResult GetWorldData()
    {
        var world = worldMapService.GetWorld();
        return Json(world);
    }
}
