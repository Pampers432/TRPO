using Microsoft.AspNetCore.Mvc;
using TestShop.Data.intarfaces;
using TestShop.ViewModels;

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
            ViewBag.Title = "Страница с дверьми";
            DoorsListViewModel obj = new();
            obj.allDoors = _allDoors.AllDoors;
            obj.doorCategory = "Двери";
            return View(obj);
        }
    }
}
