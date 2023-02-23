using System; 
 
// Create the Reflecting class  
// Create this class and make sure to specify that it inherits from the base Activity class.
public class Reflecting: Activity 
{   
    // Attributes
    private List<string> _prompts; 
    private List<string> _questions; 
    private Random rnd = new Random();

    // private DateTime _startTime = DateTime.Now; 
    // // private DateTime _futureTime = _startTime.AddSeconds(5000); // I should pass duration as a parameter for AddSeconds
    public Reflecting(int duration)
                    : base(duration) 
    {  
        _prompts = new List<string>() 
        {  
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
         
        };
        _questions = new List<string>(){ 
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _actName = "Reflecting"; 
        _startMessage = $"Hello! You are about to start the {_actName} activity. {_description}";
    }  
    public void RunReflecting() 
    {  
        Console.WriteLine();
        DisplayStartMessage(); 
        Console.WriteLine();   

        // Give the user a time before the activity starts.
        Console.Write("Get ready...");  
        Console.WriteLine();
        PauseAndShowSpinner(5000);  

        Console.WriteLine(); 
        Console.WriteLine("Consider the following prompt: "); 
        Console.WriteLine(); 

        // Generate a random prompt from the _prompts list 
    	Console.Write($"{_prompts[rnd.Next(_prompts.Count())]}"); 
        Console.WriteLine();  
        Console.WriteLine(); 
        Console.WriteLine("When you have something in mind, press enter to continue: "); 
        Console.ReadLine();  
        Console.WriteLine("Ponder on the following questions related to that experience: "); 
        Console.WriteLine(); 
        Console.Write("You may begin in...");  

        // Timer
        for (int i = 5; i != 0; i--){ 
                Console.Write(i);
                Thread.Sleep(1000); 
                Console.Write("\b \b");
            } 
        Console.WriteLine();
 
        // Iterate through each question in _questions
        while(_duration > 0) 
        { 
            foreach (string question in _questions) 
            {
                Console.WriteLine(question); 
                PauseAndShowSpinner(10000); 
                //Console.Write("\b \b");
                _duration -= 10; 
                // Checks negative numbers in case the value the user types is lees than 10
                if (_duration <= 0)
                    break; 
                Console.WriteLine();
            }   
        } 
        Console.WriteLine(); 
        DisplayEndMessage();
    }
    
}