using System;

class Program
{
    static void Main(string[] args)
    {
        int action = 0; 
        int totalPoints = 0;  
        int points = 0; 
        List<Goal> goals = new List<Goal>();

        while (action != 6)   
        {   
            Console.WriteLine(""); 
            Console.WriteLine($"You have {totalPoints} points");
            Console.WriteLine(""); 
            Console.WriteLine("Menu:"); 
            Console.WriteLine("1) Create New Goal");  
            Console.WriteLine("2) List Goals");  
            Console.WriteLine("3) Save Goals");  
            Console.WriteLine("4) Load Goals"); 
            Console.WriteLine("5) Record Event");   
            Console.WriteLine("6) Quit");   
            Console.WriteLine("");

            Console.WriteLine("What would you like to do?");  
            action = Convert.ToInt32(Console.ReadLine());   

            if(action == 1)  
            {   
                Console.WriteLine("Select the type of goal: ");   
                Console.WriteLine("1) Simple goal");   
                Console.WriteLine("2) Eternal goal");   
                Console.WriteLine("3) Checklist goal");   
                Console.WriteLine("");  
                int goalType = Convert.ToInt32(Console.ReadLine());   

                Console.WriteLine("What is the goal?: ");  
                string name = Console.ReadLine();  
                Console.WriteLine("What is the goal about?: ");  
                string description = Console.ReadLine();   
                Console.WriteLine("What is the goal award?: ");  
                points = Convert.ToInt32(Console.ReadLine());

                if(goalType == 1) {  
                    // Create a SimpleGoal object   
                    SimpleGoal goal = new SimpleGoal(name, description, points, goalType);  
                    goals.Add(goal); 
                } 
                else if(goalType == 2) {  
                    // Create a EternalGoal object 
                    EternalGoal goal = new EternalGoal(name, description, points, goalType); 
                    goals.Add(goal);
                } 
                else {              
                    // Create a ChecklistGoal object 
                    Console.WriteLine("How many times you want to do it?: ");   
 
                    int number = Convert.ToInt32(Console.ReadLine()); 
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, goalType, number); 
                    goals.Add(goal);   
                }
            }    
            // Display
            if(action == 2)  
            { 
                for(int i = 0; i < goals.Count; i++) 
                {   
                    goals[i].Display();
                } 
            } 
            if(action == 3) 
            {  
                File file = new File();
                file.Save(goals);
            } 
            if(action == 4) 
            { 
                File file = new File(); 
                file.Load(goals);
            }
            if(action == 5) 
            {   
                // Create a temporary list of Goal that stores only goals that are still not complete
                List<Goal> incompleteGoals = new List<Goal>(); 

                int x = 1;
                foreach (Goal goal in goals)
                {
                    if (goal.IsComplete() == false)
                    {
                        incompleteGoals.Add(goal);
                        Console.Write($"{x}) ");
                        goal.Display();
                        x++;
                    }
                }
                if (incompleteGoals.Count() == 0)
                    Console.WriteLine("No incomplete goals");
                else{
                    Console.WriteLine("Select the goal you want to record");
                    int option = Convert.ToInt32(Console.ReadLine()); 
                    option -= 1;   
 
                    totalPoints += incompleteGoals[option].RecordEvent(); 

                } 
                
            } 
            if(action == 6) 
            { 
                break;
            }
        }
    }
}