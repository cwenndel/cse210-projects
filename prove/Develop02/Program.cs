using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        userchoice();   
    }

    static void userchoice()
    {
        int choice = 0;
        
        while (choice !=5){
            
            Console.WriteLine("Please select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            choice = int.Parse(Console.ReadLine());
        
            if (choice==1){
                Console.WriteLine("If I had one thing I could do over today, what would it be?");
                var register = Console.ReadLine();
                string filename = "myfile.txt";
                
            {
                using(StreamWriter outputFile = new StreamWriter(filename, true))
                {
                    outputFile.WriteLine(register);
                }
            }    
            }
            else if(choice ==2)
            {
                string filename = "myfile.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    Console.WriteLine($"{theCurrentTime} Prompt: Your register");

                    Console.WriteLine(line);
                }
            }

            else if (choice ==3)
            {

            }

            else if (choice == 4)
            {
                string filename = "myfile.txt";

                using (StreamWriter outputFile = new StreamWriter (filename));
            }
        }
    }
}