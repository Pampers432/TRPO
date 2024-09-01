namespace Классы_в_курсовой
{
    class Programm
    {

        private static void Main(string[] args)
        {   
            //SQLDoors List
            List<SQLDoor> SQLDoors = new List<SQLDoor>();
            
            string[] DoorSizes = { "2000x600мм", "2000x700мм", "2000x800мм", "2000x900мм" };
            string[] DoorPrices = { "230", "245", "256", "268" };

            for (int i = 0; i < DoorSizes.Length; i++)
            {
                SQLDoors.Add(new SQLDoor(DoorSizes[i], DoorPrices[i]));
            }

            //SQLWindows List
            List<SQLWindow> SQLWindows = new List<SQLWindow>();

            string[] WindowSizes = { "1170х1440мм", "1310х1430мм", "1320х1330мм", "1470х1400мм", "1770х1430мм" };
            string[] WindowPrices = { "523", "545", "526", "570", "822" };

            for (int i = 0;i < WindowSizes.Length; i++)
            {
                SQLWindows.Add(new SQLWindow(WindowSizes[i], WindowPrices[i]));
            }

            //DoorsToOrder List
            List<DoorToOrder> DoorsToOrder = new List<DoorToOrder>();

            //WindowsToOrder List
            List<WindowToOrder> WindowsToOrder = new List<WindowToOrder>();

        }
    }
}



