using System;
 
// Create the Program class. 
class Program 
{  
    static void Main(string[] args)
    {     
        int action = 0;
        // Create a new Journal instance 
        Journal journal = new Journal();    

        File file = new File();  
 
        // Create a new instance of the StreamReader
        StreamReader _fileName = new StreamReader("myfile.txt");

        Entry entry = new Entry();  
         
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
                file.LoadFromAFile(_fileName);
            } 
            else if (action == 4) 
            { 
                journal.ProcessFile();
            } 
            else if (action == 5) 
            { 

            }
        }



 
    }

}