namespace Классы_в_курсовой
{
    class Programm
    {

        private static void Main(string[] args)
        {
            SQLDoor SQLdoor1 = new SQLDoor("2000x600мм", "230");
            SQLDoor SQLdoor2 = new SQLDoor("2000x700мм", "245");
            SQLDoor SQLdoor3 = new SQLDoor("2000x800мм", "256");
            SQLDoor SQLdoor4 = new SQLDoor("2000x900мм", "268");

            SQLWindow SQLwindow1 = new SQLWindow("1170х1440мм", "523");
            SQLWindow SQLwindow2 = new SQLWindow("1310х1430мм", "545");
            SQLWindow SQLwindow3 = new SQLWindow("1320х1330мм", "526");
            SQLWindow SQLwindow4 = new SQLWindow("1470х1400мм", "570");
            SQLWindow SQLwindow5 = new SQLWindow("1770х1430мм", "822");

        }
    }
}



