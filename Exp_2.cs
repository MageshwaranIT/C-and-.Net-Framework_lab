using System;

class Person
{
    public string name;
    public int age;

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person
{
    public int mark;

    public void DisplayStudent()
    {
        DisplayPerson();
        Console.WriteLine("Mark: " + mark);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.name = "Priya";
        s.age = 20;
        s.mark = 90;

        s.DisplayStudent();
    }
}