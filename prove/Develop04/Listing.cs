using System; 
 
// Create the Listing class  
// Create this class and make sure to specify that it inherits from the base Activity class.
public class Listing: Activity 
{    
    // Attributes
    private List<string> _prompts;   
    private string _fileName; 
    private List<string> _list = new List<string>();
    DateTime currentDate = DateTime.Now; // Set it to private for this class  
    // Store the date out of the method so I can use the variable as many times as I want
    private string _dateText;    
    private string _prompt;   
    private string _response; 


    public Listing(int duration)
                  : base(duration)
    {  
        // Here I should pass the Listing specific variables    
        _prompts = new List<string>() 
        { 
            "Who are people that you appreciate?", "What are personal strengths of yours?",  
            "Who are people that you have helped this week?",  
            "When have you felt the Holy Ghost this month?",  
            "Who are some of your personal heroes?" 
        };  
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _actName = "Listing";
        _startMessage = $"Hello! You are about to start the {_actName} activity. {_description}"; 

    }   
    public void SetVariables(string dateText, string prompt, string response) 
    { 
        _dateText = dateText;  
        _prompt = prompt; 
        _response = response;

    }
    // Methods 
    public void RunListing() 
    {   
        Console.WriteLine();
        SetVariables(_dateText, _prompt, _response);
        DisplayStartMessage();  
        Console.WriteLine();  

        // Give the user a time before the activity starts. 
        Console.Write("Get ready...");   
        PauseAndShowSpinner(5000);
          
        int index = 0;  
 
        Console.WriteLine(); 
        Console.WriteLine();
        Console.WriteLine("Enter the file name (file-name.txt): ");
        _fileName = Console.ReadLine(); 
 
        // Iterated through each prompt in _prompts:
        foreach(string item in _prompts) 
        { 
            Console.WriteLine();    

            Write(index);     
            SaveFile();    

            index += 1; 
        }  
        Console.WriteLine();   
        DisplayEndMessage();
    }     
 
    // Stores user response
    public void Write(int index) 
    { 
        _dateText = currentDate.ToShortDateString();   
        // I call the GeneratePrompt() method from the PromptGenerator class and I store the prompt in a variable.
        _prompt = GeneratePrompt(index); 
        
        // Display the prompt for the user to answer
        Console.Write(_prompt);  
        // I store the user response in the _response variable
        _response = Console.ReadLine();  
        Console.WriteLine(); 
    } 
    public string GeneratePrompt(int index)  
    {    
        return _prompts[index];
    } 


    // Challenge
    public void LoadFile() 
    {  
        // Allow the user to load from any file, even a previously created one:
        Console.WriteLine("Enter the file name you'd like to load (file-name.txt): ");
        _fileName = Console.ReadLine(); 

        string[] fullList = File.ReadAllLines(_fileName); //ReadAllLines() takes all lines in a file and put it in an array
                                                          //ToList() converts it to a list of strings. 
        for(int i = 0; i < fullList.Length; i++) // It iterates 3 by 3 so that we have the _dateText, _prompt and _response
        {  
                _response = fullList[i];   

                // Display
                Console.WriteLine(_response); 
        } 
        Console.WriteLine(); 
    }

    public void SaveFile()
    {
        // Save  
        using (StreamWriter file = new StreamWriter(_fileName, append:true)) // append appends to the file instead of overwriting the previous entry
        { 
            file.WriteLine($"{_dateText} - {_prompt} - {_response}");
        }
    }
}         
 
