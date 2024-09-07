using Microsoft.AspNetCore.Mvc;
using TestShop.Data.intarfaces;

namespace TestShop.Controllers
{
    public class DoorsController : Controller
    {
        private readonly IDoor _allDoors;

        private readonly ICategory _allCategories;

        public DoorsController(IDoor iDoor, ICategory iCategory)
        {
            _allDoors = iDoor;
            _allCategories = iCategory;
        }

        public ViewResult List()
        {
            ViewBag.Category = "Some new";
            var doors = _allDoors.AllDoors;
            return View(doors);
        }
    }
}
