using System;

public class FileClass
{ 
    public string _fileName;
    public void LoadFromAFile(List<Entry> _entryList)
    {
        // Code developed with the help of Dallin Olson (instructor from BYUI)
        try
        { 
            Console.WriteLine("Enter the file name (file-name.txt): ");
            string _fileName = Console.ReadLine();

            string[] fullList = File.ReadAllLines(_fileName); //ReadAllLines() takes all lines in a file and put it in an array
                                                                           //ToList() converts it to a list of strings. 

            for(int i = 0; i < fullList.Length; i+=3) // It iterates 3 by 3 so that we have the _dateText, _prompt and _response
            { 
                // Create an object  
                Entry entry = new Entry(); 
                entry._dateText = fullList[i]; 
                entry._prompt = fullList[i+1]; 
                entry._response = fullList[i+2]; 
                _entryList.Add(entry);
            }
        }

        // Handling errors.
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

    }

    public void ProcessFile(List<Entry> _entryList)
    {
        Console.WriteLine("Enter the file name (file-name.txt): ");
        _fileName = Console.ReadLine();

        // Save 
        using (StreamWriter file = new StreamWriter(_fileName, append:true)) // append appends to the file instead of overwriting the previous entry
        {
            foreach (Entry entry in _entryList)
            {
                // Get entry information 
                entry.Display();

                file.WriteLine($"{entry._dateText} \n {entry._prompt} \n {entry._response}");
            }
        }
        Console.WriteLine("File saved");
    }
}

