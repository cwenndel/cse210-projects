using System;

class Program
{
    static void Main(string[] args)

    {

        Console.WriteLine("What is the magic number? ");
        var magicnumber = Console.ReadLine();
        int number = int.Parse(magicnumber);


        int choice = 1;
        while (choice != number)
        {
            Console.WriteLine("What is your guess? ");
            choice = int.Parse(Console.ReadLine());
           
            if (choice < number)
            {
                Console.WriteLine("Lower");
            }
            else if (choice > number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guess it");
            }
        }
    }
}