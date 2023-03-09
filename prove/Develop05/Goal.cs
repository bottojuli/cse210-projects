using System; 
 
// This class MUST be declared as an abstract class, since we used an abstract method later.
public abstract class Goal 
{  
    // Attributes that are common for all derived classes 
    protected bool _isComplete;   
    protected string _name;  
    protected string _description;   
    protected int _points; 
    protected int _goalType; 

    public Goal(string name, string description, int points, int goalType) 
    {   
        // Set the initial value for the three variables.
        _name = name; 
        _description = description;  
        _points = points; 
        _goalType = goalType;
        _isComplete = false;
    }   

    // Second constructor that covers potentially finished goals
    public Goal(string name, string description, int points, int goalType, bool IsComplete)
    {   
        // Set the initial value for the three variables.
        _name = name; 
        _description = description;  
        _points = points; 
        _isComplete = IsComplete; 
        _goalType = goalType;
    } 
 
    // Getters
    public string GetName() { 
        return _name;
    }  
    public string GetDescription() { 
        return _description;
    }   
    public int GetPoints() { 
        return _points;
    }   
    public bool GetIsComplete() { 
        return _isComplete;
    }  
    public int GetGoalType() { 
        return _goalType;
    } 

    // Setters
    public void SetName(string name) { 
        _name = name;
    }  
    public void SetDescription(string description) { 
       _description = description;
    }

    // Abstract method 
    public abstract int RecordEvent();


    // Methods 
    public virtual void Display() 
    {  
        if(_isComplete == true) { 
            Console.WriteLine($"[X] | {_name} | {_description}");
        }
        else 
        { 
            Console.WriteLine($"[ ] | {_name} | {_description}");
        }
    }

    public bool IsComplete()
    {  
        return _isComplete;
    }  

    public virtual int GetNumber()
    { 
        return 0;
    }
    public virtual int GetCounter() 
    { 
        return 0;
    }


}