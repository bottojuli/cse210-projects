using System;
 
// Create the Program class. 
class Program 
{  
    static void Main(string[] args)
    {     
        int action = 0;
        // Create a new Journal instance 
        Journal journal = new Journal();    

        FileClass file = new FileClass();  

        while (action != 5) 
        { 
            Console.WriteLine("");
            Console.WriteLine("1) Write");  
            Console.WriteLine("2) Display");  
            Console.WriteLine("3) Load");  
            Console.WriteLine("4) Save");  
            Console.WriteLine("5) Quit");   
            Console.WriteLine("");

            Console.WriteLine("What would you like to do?");  
            action = Convert.ToInt32(Console.ReadLine());   

            if (action == 1) 
            {  
                // I call the AddEntry method from the Journal class by using the journal object 
                journal.AddEntry();  
                Console.WriteLine("");
            }   
            else if (action == 2) 
            { 
                journal.DisplayAllEntries();
            } 
            else if (action == 3) 
            { 
                file.LoadFromAFile(journal._entryList);
            } 
            else if (action == 4) 
            { 
                file.ProcessFile(journal._entryList);
            } 
            else if (action == 5) 
            { 

            }
        }

    }

}