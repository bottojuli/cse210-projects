using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? "); 
        string userInput = Console.ReadLine();   
          
        // converts the string input variable into an int so we can compare numbers in the if blocks
        int grade = int.Parse(userInput); 
 
        // declare a letter variable for storing the grades inside of the blocks
        string letter = "";

        if (grade >= 90)  
        { 
            letter = "A";
        }
        else if (grade >= 80) 
        { 
            letter = "B";
        }
        else if (grade >= 70) 
        { 
            letter = "C";
        }
        else if (grade >= 60) 
        { 
            letter = "D";
        }
        else if (grade < 60) 
        { 
            letter = "F";
        }  
         
        // prints the grade
        Console.WriteLine($"Your grade is {letter}"); 
 

        // tells the student is ThreadPriority passed or not
         if (grade >= 70)  
        { 
           Console.WriteLine("Congratulations! You passed the class!"); 
        } 
        else 
        { 
            Console.WriteLine("Sorry, you didn't pass the class, but keep striving for next semester!");
        }

    }
}