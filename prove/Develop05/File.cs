using System; 

public class File 
{ 
    private string _fileName;  
    private int _counter;
 
    public File() 
    {    
    }
    public void Save(List<Goal> goals)
    { 

        Console.WriteLine("Enter the file name (file-name.txt): ");
        _fileName = Console.ReadLine(); 

        // Save 
        using (StreamWriter file = new StreamWriter(_fileName)) // append appends to the file instead of overwriting the previous entry
        {
            foreach (Goal goal in goals)
            {  
                if(goal.GetGoalType() != 3) 
                { 
                    file.WriteLine($"{goal.GetGoalType()} | {goal.GetName()} | {goal.GetDescription()} | {goal.GetPoints()} | {goal.GetIsComplete()}"); 
                } 
                else 
                { 
                    file.WriteLine($"{goal.GetGoalType()} | {goal.GetName()} | {goal.GetDescription()} | {goal.GetPoints()} | {goal.GetIsComplete()} | {goal.GetCounter()} | {goal.GetNumber()}"); 
                }
            }
        } 
        Console.WriteLine("File saved");
    }   

    public void Load(List<Goal> goals) 
    { 
        Console.WriteLine("Enter the file name (file-name.txt): ");
            string _fileName = Console.ReadLine();

            string[] line = System.IO.File.ReadAllLines(_fileName);  
            
            for(int i = 0; i < line.Length; i++)
            {     
                string[] column = line[i].Split("|"); 

                if(column[0] == "1 ") 
                {    
                    // 1 | Eat today | Eating every meal | 20 | False
                    // name, descr, points, type, complete
                    SimpleGoal g = new SimpleGoal(column[1], column[2], Convert.ToInt32(column[3]), Convert.ToInt32(column[0]), Convert.ToBoolean(column[4])); 

                    goals.Add(g); 
                } 
                 
                else if(column[0] == "2 ") 
                {   
                    // 2 | Attend church | Attend church every sunday | 100 | False
                    // name, description, points, goalType
                    EternalGoal g = new EternalGoal(column[1], column[2], Convert.ToInt32(column[3]), Convert.ToInt32(column[0]));  

                    goals.Add(g); 
                }  

                else if(column[0] == "3 ") 
                {     
                    // 3 | Attend tutoring three times this week | Attend church | 50 | False | 0 | 3  
                    // name, description, points, goalType, number, counter, IsComplete 

                    ChecklistGoal g = new ChecklistGoal(column[1], column[2], Convert.ToInt32(column[3]), Convert.ToInt32(column[0]), Convert.ToInt32(column[6]), Convert.ToInt32(column[5]), Convert.ToBoolean(column[4]));  

                    goals.Add(g); 
                }  
            }
    } 


}