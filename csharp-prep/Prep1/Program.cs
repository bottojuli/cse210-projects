using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");  
        // store the input in a variable
        string name = Console.ReadLine(); 

        Console.Write("What is your last name? ");  
        // store the input in a variable
        string lastname = Console.ReadLine(); 

        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");
    }
}