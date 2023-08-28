using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using WeddingOrganization.PresantationLayer.Models;

namespace WeddingOrganization.PresantationLayer.Controllers
{
    public class LocationImageController : Controller
    {
        private readonly ILocationService _locationService;

        public LocationImageController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ImageFileViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            Location location = new Location();
            //_locationService.TInsert(location);
            return RedirectToAction("ImageList");
        }
    }
}
