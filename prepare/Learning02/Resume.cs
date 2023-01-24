using System;    

// Create a new file for your Resume class. Each class should be in its own file and the file name should match  
// the name of the class.

// Create the Resume class.
public class Resume 
{ 
 
    // Create the member variable for the person's name.
    public String _name = "";  

    // Create the member variable for the list of Jobs. (Hint: the data type for this should be List<Job>, and it is  
    // probably easiest to initialize this to a new list right when you declare it) 
    public List<Job> _jobs = new List<Job>(); 
  
    public void ShowEasternName() 
    {  
        Console.WriteLine($"{_name}"); 
        Console.WriteLine($"{_jobs}"); 
    }  

    public void ShowWesternName() 
    {  
        Console.WriteLine($"{_name}"); 
        Console.WriteLine($"{_jobs}"); 
    }  

// Return to your Resume class and add a method to display its details.
// This method should not have any parameters and should not return anything.

    // Add a method (member function) to display the resume details.    
    public void DisplayResumeDetails() 
    {  
        // In the method body, you should display the person's name and then iterate through each Job instance  
        // in the list of jobs and display them.  
        // Hint: remember that you can call each job's Display method that you created earlier.  

        Console.WriteLine($"{_name}"); 
        Console.WriteLine($"Jobs: "); 

        foreach (Job job in _jobs) // I'm getting into the Job file and into the _jobs list that is hold there.
        { 
             // This line of code calls the DisplayJobDetails method on each job. 
             job.DisplayJobDetails();
        }
           
 
    }

} 