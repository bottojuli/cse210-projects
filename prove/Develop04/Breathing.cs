using System; 
 
// Create the Breathing class  
// Create this class and make sure to specify that it inherits from the base Activity class.
public class Breathing: Activity 
{  
    // Attributes  

    // Creathing breathing = new Breathing( s, e, d, n, d)

    public Breathing(int duration)
                    : base(duration) 
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _actName = "Breathing";
        _startMessage = $"Hello! You are about to start the {_actName} activity. {_description}";
    }

    // Methods
    public void RunBreathing() 
    { 
        DisplayStartMessage();  
        // Give the user a time before the activity starts.
        Console.Write("Get ready..."); 
        PauseAndShowSpinner(5000);
        Console.WriteLine();
        while (_duration > 0){
            Console.Write("Breath in...");
            for (int i = 4; i != 0; i--){
                Console.Write(i);
                Thread.Sleep(1000); 
                Console.Write("\b \b");
                _duration -= 1;
            }
            Console.WriteLine();
            Console.Write("Breath out...");
            for (int i = 6; i != 0; i--){
                Console.Write(i);
                Thread.Sleep(1000); 
                Console.Write("\b \b");
                _duration -= 1;
            }
            Console.WriteLine();
        }
    	
        DisplayEndMessage();
        Console.WriteLine();

    }
}