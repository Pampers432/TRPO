namespace Классы_в_курсовой
{
    class DoorToOrder : Product
    {
        private int count { get; set; }

        private int Count
        {
            set {
                if (value == 0)
                {
                    this.count = 0;
                }
            }
        }

        public DoorToOrder(string size, string price)
        {
            this.size = size;
            this.price = price;
        }

        //public void DisplayData(SQLDoor door)
        //{
        //    Console.WriteLine($"Door: {door.Size}, Price: {door.Price}");
        //}
    }

    class WindowToOrder : Product
    {   
        private int count { get; set; }

        private int Count
        {
            set
            {
                if (value == 0)
                {
                    this.count = 0;
                }
            }
        }

        public WindowToOrder(string size, string price)
        {
            this.size = size;
            this.price = price;
        }
        //public void DisplayData(SQLWindow window)
        //{
        //    Console.WriteLine($"Window: {window.Size}, Price: {window.Price}");
        //}
    }
}
