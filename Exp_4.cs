using System;
delegate void ProductDelegate();

class Shopping
{
    public void Product1()
    {
        Console.WriteLine("----- Product 1 -----");
        Console.WriteLine("Product : Laptop");
        Console.WriteLine("Price   : Rs. 55000");
        Console.WriteLine("Brand   : Dell");
        Console.WriteLine();
    }

    public void Product2()
    {
        Console.WriteLine("----- Product 2 -----");
        Console.WriteLine("Product : Mobile");
        Console.WriteLine("Price   : Rs. 18000");
        Console.WriteLine("Brand   : Samsung");
    }
}

class Program
{
    static void Main(string[] args)
    {
    Shopping obj = new Shopping();
        ProductDelegate pd;
        pd = obj.Product1;
        pd();
        pd = obj.Product2;
        pd();

        Console.ReadKey();
    }
}