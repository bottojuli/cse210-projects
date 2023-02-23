using System; 
 
public class Activity 
{  
    // Attributes  
    protected string _actName; 
    protected string _description; 
    protected int _duration;    
    protected string _message; 
    protected string _startMessage; 
    protected string _endMessage;   

    // Constructors 
    public Activity(int duration) 
    {       
        // Initialize all the variables that are common for the children classes (derived classes). 
        _endMessage = "Great job!";
        _duration = duration;

    } 

    // Methods
    public void DisplayStartMessage()
    { 
        Console.WriteLine(_startMessage);
    }  
    //method to display
    public void DisplayEndMessage() 
    { 
        Console.WriteLine(_endMessage);
    }
   
    public void PauseAndShowSpinner(int time) 
    {        
        int timeSpinner = 0;
        while(timeSpinner < time) 
        { 
            Console.Write("|"); 
            Thread.Sleep(200); 
            timeSpinner += 200;  
            Console.Write("\b \b"); 

            Console.Write("/"); 
            Thread.Sleep(200); 
            timeSpinner += 200;  
            Console.Write("\b \b"); 

            Console.Write("―"); 
            Thread.Sleep(200); 
            timeSpinner += 200; 
            Console.Write("\b \b"); 

            Console.Write("\\"); 
            Thread.Sleep(200); 
            timeSpinner += 200; 
            Console.Write("\b \b"); 
        }
    } 
} 
