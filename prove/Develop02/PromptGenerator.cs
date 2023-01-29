using System;  

// Create the class. 
public class PromptGenerator 
{    
    List<string> _prompts = new List<string>(); 
   
    // Constructor method. It will just be executed ONCE and doesn't return anything.
    public PromptGenerator() 
    { 
        _prompts.Add("Who was the most interesting person I interacted with today?"); 
        _prompts.Add("What was the best part of my day?"); 
        _prompts.Add("How did I see the hand of the Lord in my life today?"); 
        _prompts.Add("What was the strongest emotion I felt today?"); 
        _prompts.Add("If I had one thing I could do over today, what would it be?"); 
        _prompts.Add("Is there something you felt like you have to change to be happier?"); 
        _prompts.Add("Are you satisfied with your behavior of today?"); 
        _prompts.Add("How are you actually feeling today?"); 
    }
    public string GeneratePrompt()  
    {   
        // Pick a random option by calling the built-in Random method 
        Random rnd = new Random(); 
        int randomIndex = rnd.Next(1, 8); 

        return _prompts[randomIndex];
    }

}