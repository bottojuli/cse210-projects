// You program should contain two classes one for a Job and one for the Resume itself, as follows:  

// Class: Job
// Responsibilities:
// Keeps track of the company, job title, start year, and end year. 
// Behaviors:
// Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example:  
// "Software Engineer (Microsoft) 2019-2022". 
// Engineer (Microsoft) 2019-2022". 

// Class: Resume 
// Responsibilities:
// Keeps track of the person's name and a list of their jobs. 
// Behaviors:
// Displays the resume, which shows the name first, followed by displaying each one of the jobs. 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");  

         
        // Create a new job instance named job1   
        Job job1 = new Job();

        // Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
        job1._company = "Coca-Cola"; 
        job1._jobTitle = "Repository"; 
        job1._startYear = "2010"; 
        job1._endYear = "2023";    
        // Call the methods in order to display the variables. 

        // Return to your Program.cs file. Remove the lines of code where you displayed the company earlier, and  
        // replace them with calls to your new method. Remember that you call the method using the same dot notation  
        // such as job1.Display(); 

        // job1.ShowEasternName();  
        // job1.DisplayJobDetails();

        // Create a second job, set its variables, display this company on the screen as well.  
        Job job2 = new Job();
        job2._company = "McDonalds"; 
        job2._jobTitle = "Cashier"; 
        job2._startYear = "2020"; 
        job2._endYear = "2023";   
        // Call the methods in order to display the variables. 

        // Return to your Program.cs file. Remove the lines of code where you displayed the company earlier, and  
        // replace them with calls to your new method. Remember that you call the method using the same dot notation  
        // such as job1.Display(); 

        // job2.ShowEasternName();  
        // job2.DisplayJobDetails();  




        // Return to your Program.cs. At the end of the Main function, create a new instance of the Resume class.
        Resume myResume = new Resume();  

        myResume._name = "Lady Gaga";   
        
        // Add the two jobs you created earlier, to the list of jobs in the resume object.  
        myResume._jobs.Add(job1);  
        myResume._jobs.Add(job2); 

        // Verify that you can access and display the first job title using dot notation similar to  
        // myResume._jobs[0]._jobTitle.  
        // Console.WriteLine($"{myResume._jobs[0]._jobTitle}"); 

        // Return to your main function, remove any code that is displaying information, and instead, add a call at the end  
        // to the Display method from your Resume class to display the name and all the jobs in one line. } 
        myResume.DisplayResumeDetails(); 

    }   

    



}