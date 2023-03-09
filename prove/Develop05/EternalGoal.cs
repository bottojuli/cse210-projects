using System; 
 
public class EternalGoal: Goal  
{  
    // Attributes 

    public EternalGoal(string name, string description, int points, int goalType):  
                base(name, description, points, goalType) {  
 
    }
    public override int RecordEvent()
    { 
        return _points;
    }

}