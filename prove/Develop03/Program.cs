using System;

class Program
{
    static void Main(string[] args)
    {   
       // Read each line from the .txt file and stores them inside of an array (list type):
       string[] scripturesArray = System.IO.File.ReadAllLines(@"C:\Users\Usuario\Documents\JULIETA\PATHWAY\BYU\Programming With Classes\cse210-projects\prove\Develop03\myscriptures.txt");
        
       // This prints the whole scriptures string[]: 
       // System.Console.WriteLine(scripturesArray);   

       List<Scripture> scriptureList = new List<Scripture>();  
         
       int counter = 1; 

       // This for loop prints the whole list of scriptures:
       for(int i = 0; i < scripturesArray.Length; i+=2) { // It adds 2 since every scripture takes 2 lines of code. The first is the reference, and the second is the scripture.
           // Create an instance of the Scripture class that calls the Scripture constructor that takes two parameters (one for the reference, other for the scripture).
           Scripture scr = new Scripture(scripturesArray[i], scripturesArray[i+1]); // scripturesArray[i] is the reference, scripturesArray[i+1] is the scripture 
           // This adds every scripture and reference to the scriptureList array. 
           scriptureList.Add(scr); 

           Console.WriteLine($"{counter++})");
           Console.WriteLine(scripturesArray[i]); // Prints the reference 
           Console.WriteLine(scripturesArray[i+1]); // Prints the scripture
           Console.WriteLine(""); // Print a white line

       }           
        // Ask the user for a scripture to memorize:  
        Console.Write("Select the scripture you desire to memorize: ");  
        int inputIndex = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine();
        inputIndex = inputIndex - 1; // I substract 1 unit to addapt it to the list index.   
         
        // Call the HideWords() method using the scriptureList[inputIndex] object. 
        Console.Clear();
        scriptureList[inputIndex].HideWords(); 
    }
} 


// Read from a file: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file 
