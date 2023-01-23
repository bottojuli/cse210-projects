using System;

class Program
{
    static void Main(string[] args)
    { 
        bool guess = false;  
        int counter = 1;

        // Resource used: https://www.w3schools.blog/c-random-number 
        // Generate a random number using the Random() function
        Random rnd = new Random();  
        // The Next function returns a random number from the rnd variable from the specified range
        int magicNumber = rnd.Next(1, 100);

        while(guess == false)  
        {  
            // Print a message asking the user for a number
            Console.Write("What is your guess? ");   

            // Let the user enter a number and store the input in a variable  
            string input2 = Console.ReadLine();  
 
            // Convert the string input into an int type
            int guessNumber = int.Parse(input2); 

            if(magicNumber < guessNumber)
            { 
            Console.WriteLine("Lower");
            }  
            if(magicNumber > guessNumber) 
            { 
                Console.WriteLine("Higher");
            }
            if(magicNumber == guessNumber)
            { 
                Console.WriteLine("You guessed it!");  
             
                Console.WriteLine("Do you want to play again? (yes/no)");  
                string playAgain = Console.ReadLine();  
                 
                if(playAgain == "no") 
                {   
                    guess = true;    
                } 
                if(playAgain == "yes") 
                { 
                    // I generated a new random number
                    magicNumber = rnd.Next(1, 100);  
                }  
                
                // Print the number of guesses  
                Console.WriteLine($"Gueses: {counter}");
            }   

            // Increments the counter one unit at a time
            counter ++;
        } 


    }
}