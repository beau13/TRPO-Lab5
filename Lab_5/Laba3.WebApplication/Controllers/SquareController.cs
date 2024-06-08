using Laba3.ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Laba3.WebApplication.Models;

namespace Laba3.WebApplication.Controllers
{
    public class SquareController : Controller
    {
        [HttpGet]
        public IActionResult Index(CyclinderModel vm)
        {
            return View(vm);
        }

        [HttpPost]
        public IActionResult Calculator(IFormCollection collection, CyclinderModel vm)
        {
            double Radius = vm.Radius;
            double Height = vm.Height;
            double Cyclinder = new Cylinder_surface_area().Cylinder_surface_area_formula(Radius, Height);
            vm.Cyclinder = Cyclinder;
            return View(vm);
        }
    }
}
