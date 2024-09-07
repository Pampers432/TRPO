using TestShop.Data.Models;

namespace TestShop.ViewModels
{
    public class DoorsListViewModel
    {
        public IEnumerable<Door> allDoors {  get; set; }

        public string doorCategory { get; set; }
    }
}
