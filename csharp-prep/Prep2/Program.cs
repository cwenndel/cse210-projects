using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Type your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Letter A");
        }
        else if (gradePercentage >=80)
        {
            Console.WriteLine("Letter B");
        }
        else if (gradePercentage >=70)
        {
            Console.WriteLine("Letter C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Letter D");
        }
        else
        {
            Console.WriteLine("Letter F");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You Passed. Congratulation!");
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }
}