using System;

class Student
{
    public string name;
    public int mark;

    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Mark: " + mark);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.name = "pagal";
        student1.mark = 85;

        student1.Display();
    }
}