using System;  

// Create the class.  
// Process the text entry that is entered by the user as an input.
public class Journal 
{   
    // Create the member variable for the list of entries in the journal list. (Hint: the data type for this should be List<Job>, and it is  
    // probably easiest to initialize this to a new list right when you declare it) 
    public List<Entry> _entryList = new List<Entry>();  

    // I declare the functions/methods that this class will use. 
    public void AddEntry()  
    {    
        // Create an object inside in order to create it every time we use the method for every new entry
        Entry _entry = new Entry();  
        // _entry holds the users text
        _entry.Write(); 
        // Store the text data inside of the _entryList 
        _entryList.Add(_entry);
    } 

    public void DisplayAllEntries() 
    { 
        foreach (Entry entry in _entryList) // This line of code calls the Display method from the Entry class.
        { 
            // This line displays every item inside of the _entryList list. 
            entry.Display();  
            // By this way, every entry is written in a different line and its more readable.
            Console.WriteLine("");
        }
    } 

    // public string _fileName; 
    // Enter file name, save and load.
    // public void ProcessFile() 
    // { 
    //     Console.WriteLine("Enter the file name (file-name.txt): "); 
    //     _fileName = Console.ReadLine(); 

    //     // Save 
    //     using (StreamWriter file = new StreamWriter(_fileName)) 
    //     {   
    //         foreach (Entry entry in _entryList) 
    //         { 
    //             // Get entry information 
    //             entry.Display(); 

    //             file.WriteLine($"{entry._dateText} {entry._prompt} {entry._response}");   
    //         }
    //     }
    //     Console.WriteLine("File saved");
    // } 


} 
 
 
 
 
// using System;  

// // Create the class.  
// // Process the text entry that is entered by the user as an input.
// public class Journal 
// {  
//     // Create the member variable for the list of entries in the journal list. (Hint: the data type for this should be List<Job>, and it is  
//     // probably easiest to initialize this to a new list right when you declare it)  

//     // public List<Entry> _entryList = new List<Entry>();   
//     public List<List<string>> _entryList = new List<List<string>>(); // A list of lists 

//     // I declare the functions/methods that this class will use. 
//     public void AddEntry()  
//     {    
//         // Create an object inside in order to create it every time we use the method for every new entry
//         Entry _entry = new Entry();   

//         // _entry holds the users text
//         _entry.Write(); 
//         // Store the text data inside of the _entryList 
//         _entryList.Add(_entry.getData());
//     } 

//     public void DisplayAllEntries() 
//     { 
//         foreach (Entry entry in _entryList) // This line of code calls the Display method from the Entry class.
//         { 
//             // This line displays every item inside of the _entryList list. 
//             entry.Display();
//         }
//     } 




// }