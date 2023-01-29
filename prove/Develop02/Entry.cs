using System;  

// Create the class. 
public class Entry 
{      
    // Variable declarations so they can be re-used
    public string _response; 
    public List<string> _list = new List<string>();
    DateTime currentDate = DateTime.Now; // Set it to private for this class  
    // Store the date out of the method so I can use the variable as many times as I want
    public string _dateText;  
    public string _prompt; 

    // Create a class object so we can reference it later 
    PromptGenerator _promptGenerator = new PromptGenerator();

    public void Display()  
    {   
        // Display the current date and the response typed by the user. 
        Console.Write(_dateText); 
        Console.Write(_prompt);
        Console.Write(_response); 
    }   

    // Stores user response
    public void Write() 
    { 
        _dateText = currentDate.ToShortDateString();   
        // I call the GeneratePrompt() method from the PromptGenerator class and I store the prompt in a variable.
        _prompt = _promptGenerator.GeneratePrompt(); 
        
        // Display the prompt for the user to answer
        Console.Write(_prompt);  
        // I store the user response in the _response variable
        _response = Console.ReadLine();
    }

}