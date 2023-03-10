using System; 

// Follow the same pattern as before by creating a new file for the WritingAssignment class.
// Create the class and set up the inheritance relationship. 
public class WritingAssignment : Assignment 
{ 
    // Add the member variables and set up the constructor as you did for the MathAssignment class. 
    private string _title; 
     
    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic)
    {   
        // I need to give the value to the title variable because otherwise I can't reach out to it later when I  
        // intialize an object from WritingAssignment. 
        // I set the specific variables for the WritingAssignment class.
        _title = title; 
    } 

    // Add the GetWritingInformation() method.  
    // Notice that this method needs to access the _studentName variable defined in the base class.  
    // Even though WritingAssignment class inherited this attribute, it is private, so you cannot access it directly  
    // in the derived class. 
    // To get the data you need for the method you can either make the variable protected in the base class, or you  
    // can create a public GetStudentName method to return it.
    public string GetWritingInformation() 
    {  
        // If I wouldn't set _studentName as protected, I would have to call the GetStudentName method in order to have access to it.  
        // This happens when we set an attribute as private in the base class.
        return $"{_title} by {_studentName}";
    }

}
