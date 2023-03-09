using System; 

public class SimpleGoal: Goal 
{  
    // Attributes  

    public SimpleGoal(string name, string description, int points, int goalType):  
                base(name, description, points, goalType) {  
 
    } 
    // Create new constructor for finished goals 
    public SimpleGoal(string name, string description, int points, int goalType, bool IsComplete):  
                base(name, description, points, goalType, IsComplete) {  
    
    } 
    public override int RecordEvent() 
    {    
        _isComplete = true;
        return _points;
    }


    
}