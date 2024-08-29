using System.Drawing;

class Programm 
{ 
    
    private static void Main(string[] args) 
    {
        Door door1 = new Door();
        door1.AddElement();
    }
}

class Product 
{ 
    public string Size { get; set; } 

    public string Price { get; set; }

    public void AddElement() 
    {
        Console.Write("Введите кол-во: ");
        Size = Console.ReadLine();
        Console.Write("Введите стоимость: ");
        Price = Console.ReadLine();
    }
}

class Door : Product 
{
    
}

class Window : Product 
{
    
}