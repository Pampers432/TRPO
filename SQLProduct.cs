using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_в_курсовой
{
    class SQLDoor : Product
    {
        public SQLDoor(string size, string price)
        {
            Size = size;
            Price = price;
        }
    }

    class SQLWindow : Product
    {
        public SQLWindow(string size, string price)
        {
            Size = size;
            Price = price;
        }
    }
}
