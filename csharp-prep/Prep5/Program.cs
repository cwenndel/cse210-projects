using System;

class Program
{
    static void Main(string[] args)
    {
        message();
        var name = getname();
        int calc = favoriteNumber();
        {
            Console.WriteLine($"{name}, the square of your number is {calc}");
        }
    }
    static void message()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string getname()
    {
        Console.WriteLine("Please enter your name: ");
        var name = Console.ReadLine();
        return name;
    }
    static int favoriteNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        var number = int.Parse(Console.ReadLine());

        var calc = (int) Math.Pow(number, 2);
        Console.WriteLine(calc);
        return calc;
    }
}