using System;
// Activity Instructions
// Practice the principle of inheritance by creating a base class and derived classes.

// For this activity, you will write classes to represent different kinds of homework assignments. Consider the  
// following example of Math and writing assignments.

// Math Assignments
// A Math assignment may need to store the student's name, the topic (for example, "Fractions"), the textbook  
// section (for example, "7.3"), and the problems from that section (for example, "3-10, 20-21").

// The Math assignment should have a constructor that requires a value for each of the items that it stores.

// The Math assignment needs to provide a method to return a summary of the assignment that contains the student's  
// name and the topic, and it also needs to provide a method to display the Math homework list including the  
// section number and the problems (for example, "Section 7.3 Problems 8-19").

// Writing Assignments
// A writing assignment may need to store the student's name, the topic (for example, "European History"), and the  
// title of the assignment (for example, "The Causes of World War II").

// The writing assignment should have a constructor that requires a value for each of the items that it stores.

// The writing assignment needs to provide a method to return a summary of the assignment that contains the  
// student's name and the topic, and it also needs to provide a method to get the writing information which  
// consists of the title and the student's name (for example, "The Causes of World War II by Mary Waters").
class Program
{
    static void Main(string[] args)
    {
        // Test your class by returning to the Main method in the Program.cs file. Create a simple assignment,  
        // call the method to get the summary, and then display it to the screen. 
        Assignment assignment = new Assignment("Julieta Inostroza Botto", "Programming With Classes"); 
        Console.WriteLine(assignment.GetSummary()); 
         
        // Test your class by returning to the Main method and creating a new MathAssignment object and set its  
        // values. Make sure to test both the GetSummary() and the GetHomeworkList() methods. 
        MathAssignment mathAssignment = new MathAssignment("Julieta Inostroza Botto", "Programming With Classes", "2.5", "4-11"); 
        Console.WriteLine(mathAssignment.GetSummary()); 
        Console.WriteLine(mathAssignment.GetHomeworkList()); 

        // Return to Main and test your new class. 
        WritingAssignment writingAssignment = new WritingAssignment("Julieta Inostroza Botto", "Programming With Classes", "Inheritance"); 
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}