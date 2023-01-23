using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Declare a list variable called numbers. The () are because we are creating a new objetc.
        List<int> numbersList = new List<int>();    
 
        // Declare a boolean variable 
        bool zero = false;   

        // Declare variable to compute the average later 
        float counter = 0; 

        // Declare a variable for biggest number.
        int biggest = 0;

        // Create a variable to store the addition later 
        float total = 0; 

        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0. 
        while(zero == false) 
        {  
            // Ask the user for numbers
            Console.Write("Enter numbers: ");  
            // Store the input entered in a variable
            string input = Console.ReadLine();   
            // Convert the string input in an int type
            int number = int.Parse(input);  

            // Compute the addition of the numbers in the list 
            total = number + total;

            // Add the numbers to the list 
            numbersList.Add(number);  

            // Ask if the new number is bigger than the last 
            if (number > biggest) 
            {  
                // Store the value of number in biggest
                biggest = number;
            }
             
            // if number is 0, stop executing the while. 
            if(number == 0) 
            {  
                // Change the state of the variable so the while stops asking for new numbers.
                zero = true;
            }   
            // Increment the counter.
            counter ++;

        }
        // Compute average of the numbers in the list once the list is full.
        float average = total / counter;  
        Console.WriteLine(total);  
        Console.WriteLine(counter); 

        // Print the average 
        Console.WriteLine($"The average is: {average}");

        // Print the biggest number of the list. 
        Console.Write($"The biggest number of the list is: {biggest}");

    }
}