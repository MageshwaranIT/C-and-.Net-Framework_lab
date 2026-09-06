using System;

class Animal
{
    
    public string Name;
    public int Age;

    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine(Name + " is sleeping.");
    }
}


class Cat : Animal
{
    public void Sound()
    {
        Console.WriteLine(Name + " says: Meow Meow!");
    }

    public void ShowDetails()
    {
        Console.WriteLine("\n----- Cat Details -----");
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age  : " + Age + " Years");
    }
}

class Program
{
    static void Main(string[] args)
    {
   
        Cat c1 = new Cat();
        c1.Name = "Kitty";
        c1.Age = 2;
        c1.Eat();
        c1.Sleep();
        c1.Sound();
        c1.ShowDetails();

        Console.ReadKey();
    }
}