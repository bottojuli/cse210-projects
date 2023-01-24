using System;  

// Create the class (Hint this is the public class Job syntax). 
public class Job 
{  
    // Create member variables in the class for each element that this class should contain.  
    // By convention these member variables should begin with an underscore and a lowercase letter such  
    // as _jobTitle.  
    public string _company;   
    public string _jobTitle; 
    public string _startYear;  
    public string _endYear;    

    public void ShowEasternName() 
    {  
        Console.WriteLine($"{_company}"); 
        // Console.WriteLine($"{_jobTitle}"); 
        // Console.WriteLine($"{_startYear}"); 
        // Console.WriteLine($"{_endYear}");
    }  
    public void ShowWesternName() 
    {  
        Console.WriteLine($"{_company}"); 
    }  

    // Add a method (member function) to display the job details.    
    public void DisplayJobDetails() 
    {  
        // This method should not have any parameters and does not need to return anything.  
        // This method should display the job details on the screen in the correct format. Remember that the method  
        // can access the member variables directly, without needing them to be passed into it. 
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}"); 
    }

    
}  


