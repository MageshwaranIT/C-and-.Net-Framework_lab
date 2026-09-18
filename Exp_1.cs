using System;

class Student
{

    public string Name;
    public int RollNo;
    public string Department;
    public int Semester;
    public int Age;
    public float CGPA;
    public void Display()
    {
        Console.WriteLine("------ Student Details ------");
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Roll No    : " + RollNo);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("Semester   : " + Semester);
        Console.WriteLine("Age        : " + Age);
        Console.WriteLine("CGPA       : " + CGPA);
    }
}

class Program
{
    static void Main(string[] args)
    {
    
        Student s1 = new Student();

        s1.Name = "Pagal";
        s1.RollNo = 101;
        s1.Department = "Information Technology";
        s1.Semester = 5;
        s1.Age = 20;
        s1.CGPA = 8.2f;
        s1.Display();

        Console.ReadKey();
    }
}