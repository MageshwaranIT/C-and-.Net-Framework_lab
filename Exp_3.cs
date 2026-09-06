using System;

class Number
{
    public int Value;

    // Constructor
    public Number(int value)
    {
        Value = value;
    }

    // Overload + operator
    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.Value + n2.Value);
    }

    // Overload - operator
    public static Number operator -(Number n1, Number n2)
    {
        return new Number(n1.Value - n2.Value);
    }

    // Overload * operator
    public static Number operator *(Number n1, Number n2)
    {
        return new Number(n1.Value * n2.Value);
    }

    // Display method
    public void Display(string operation)
    {
        Console.WriteLine(operation + " Result = " + Value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Console.Write("Enter First Number : ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number : ");
        b = Convert.ToInt32(Console.ReadLine());

        // Create objects
        Number n1 = new Number(a);
        Number n2 = new Number(b);

        // Perform operations
        Number sum = n1 + n2;
        Number diff = n1 - n2;
        Number product = n1 * n2;

        // Display results
        sum.Display("Addition");
        diff.Display("Subtraction");
        product.Display("Multiplication");

        Console.ReadKey();
    }
}