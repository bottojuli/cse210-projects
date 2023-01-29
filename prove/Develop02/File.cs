using System;  
     
public class File 
{    
    // I declare the _fileName variable so I can store the file
    public string _fileName;
    private void enterFileName() 
    { 
        Console.WriteLine("Enter the file name (file-name.txt): "); 
        _fileName = Console.ReadLine();
    } 

    public void LoadFromAFile(StreamReader _file) 
    {  
        // Code provided by Microsoft resources. Bro. Carter (an instructor) provided  
        // this to his students and they shared it in a tutoring class.
        String firstLine;
            try
            { 
                //Read the first line of text
                firstLine = _file.ReadLine(); 

                //Continue to read until you reach end of file
                while (firstLine != null)
                {
                    Console.WriteLine(firstLine); 
                }
                // Close the file
                _file.Close();
            } 

            // Handling errors.
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
    } 
} 
 
