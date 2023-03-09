using System; 

public class ChecklistGoal: Goal 
{  
    // Attributes that are common for all derived classes 
    protected int _counter = 0;  
    private int _number; 
   
    public override int GetNumber() 
    { 
        return _number;
    }  
    public override int GetCounter() 
    { 
        return _counter;
    }     

    // Constructors 
    public ChecklistGoal(string name, string description, int points, int goalType, int number):  
                base(name, description, points, goalType) {
        _number = number;
    }    
    // Second constructor for complete goals
    public ChecklistGoal(string name, string description, int points, int goalType, int number, int counter, bool IsComplete):  
                base(name, description, points, goalType, IsComplete) {
        _number = number;
        _counter = counter;
    } 
    public override int RecordEvent()
    {
        Console.WriteLine("How many times have you completed the goal? ");
        int _timesCompleted = Convert.ToInt32(Console.ReadLine()); 
 
        // The counter adds units depending on how many times we completed the goal
        _counter += _timesCompleted;  

        // This conditional will let the user have the goal marked as done if they did it more times  
        // than the minimum required.
        if (_counter >= _number) 
        { 
            _isComplete = true;
        }
        else 
        { 
            _isComplete = false; 
        }  

        int total = _points * _timesCompleted;
        return total; 

    }  

    // This slightly changes, so it uses the virtual keyword to indicate that we will override the method
    public override void Display() 
    {  
        // The string helps the user track the times they completed the task
        if(_isComplete == true) { 
        Console.WriteLine($"[X] | {_name} | {_description} | {_counter}/{_number}");
        }
        else 
        { 
            Console.WriteLine($"[ ] | {_name} | {_description} | {_counter}/{_number}");
        } 
    }
}