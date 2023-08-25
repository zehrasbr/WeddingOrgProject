using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WeddingOrganization.PresantationLayer.Controllers
{
    public class LocationController : Controller
    {

        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult AddLocation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddLocation(Location location)
        {
            _locationService.TAdd(location);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteLocation(int id)
        {
            var value = _locationService.TGetByID(id);
            _locationService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateLocation(int id)
        {
            var value = _locationService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateLocation(Location location)
        {
            _locationService.TUpdate(location);
            return RedirectToAction("Index");
        }
    }
}
