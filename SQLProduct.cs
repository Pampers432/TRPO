namespace Классы_в_курсовой
{
    class SQLDoor : Product
    {
        public SQLDoor(string size, string price)
        {
            this.size = size;
            this.price = price;
        }

        //public void DisplayData(SQLDoor door)
        //{
        //    Console.WriteLine($"Door: {door.Size}, Price: {door.Price}");
        //}
    }

    class SQLWindow : Product
    {
        public SQLWindow(string size, string price)
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
