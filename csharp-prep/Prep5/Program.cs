using System;

class Program
{
    static void Main(string[] args)
    { 
        // Call the functions
        DisplayMessage(); 
        string userName = PromptUserName(); 
        PromptUserNumber(); 
        float numSquared = SquareNumber(4); 
        DisplayResult(userName, numSquared);
    }  

    // DisplayWelcome - Displays the message, "Welcome to the Program!"  
    static void DisplayMessage() 
    { 
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string) 
    static string PromptUserName() 
    { 
        Console.WriteLine("Enter your user name: "); 
        string userName = Console.ReadLine(); 
        return userName;
    }

    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer) 
    static int PromptUserNumber() 
    { 
        Console.WriteLine("Enter your favorite number: "); 
        string input = Console.ReadLine();  
 
        // Convert string input to an int.
        int favNumber = int.Parse(input);  
        return favNumber;
    } 
    
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer) 
    static int SquareNumber(int number) 
    {  
        return number;
    } 

    // DisplayResult - Accepts the user's name and the squared number and displays them.  
    static void DisplayResult(string userName, float numSquared) 
    { 
        Console.WriteLine($"{userName}, the square of your number is {numSquared}");
    }
}