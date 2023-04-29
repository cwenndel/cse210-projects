using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float average=0;
        int sum = 0;
        int number=-1;
        int max = 0;
        while(number!=0)
        {
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());

            if (number !=0)
            {   
                numbers.Add(number);
                sum += number;
                average = (float) sum / numbers.Count;
            

           
                if (number > max)
                {
                    max = number;
                }
            }
    }
    Console.WriteLine($"The Sum is: {sum}");
    Console.WriteLine($"The Average: {average}");
    Console.WriteLine($"The largest number: {max}");
}
}