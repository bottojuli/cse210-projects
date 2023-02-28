using System;
// Activity Instructions
// Practice the principle of polymorphism by writing a program that computes the areas of  
// different shapes cut out of pieces of paper.

// For all shapes, you need to keep track of the color of the paper and then have a method to  
// compute the area. The area should not be stored as a member variable, but instead, you  
// should store the length of the shapes sides and then compute the area as needed.

// Your program should include squares (which store a color and a single side), rectangles  
// (which store a color and two sides), and a circle (which store a color and a radius).  
// You should create several kinds of shapes and put them into a single list. Then, iterate  
// through the list and display their areas.

// Design the Classes
// Based on what you learned in inheritance, it seems reasonable to create a base shape class  
// where you can include any responsibilities that all shapes have in common. Then you can  
// create derived classes for the individual square, rectangle and circle shapes.

// In this example all shapes have a color and a method to get the area, but the implementation  
// of that method will be different for each kind of shape. Thus, the GetArea method should be  
// declared in the base class, but you should override it in the derived classes.
class Program
{
    static void Main(string[] args)
    {
        // Create a Square instance, call the GetColor() and GetArea() methods and make sure    
        // they return the values you expect. 
        Square square = new Square("red", 2); 
        // square.GetColor(); 
        // square.GetArea();   


        // Create a Square instance, call the GetColor() and GetArea() methods and make sure    
        // they return the values you expect. 
        Rectangle rectangle = new Rectangle("blue", 2, 3); 
        // rectangle.GetColor(); 
        // rectangle.GetArea();  
 

        // Create a Square instance, call the GetColor() and GetArea() methods and make sure    
        // they return the values you expect. 
        Circle circle = new Circle("yellow", 5); 
        // circle.GetColor(); 
        // circle.GetArea(); 
 

        // In your Main method, create a list to hold shapes (Hint: The data type should be   
        // List<Shape>). 
        List<Shape> shapes = new List<Shape>();  

        // Add any type of Shape. 

        // Add a square, rectangle, and circle to this list. 
        shapes.Add(square);   
        shapes.Add(rectangle); 
        shapes.Add(circle);

        // Iterate through the list of shapes. For each one, call and display the GetColor()  
        // and GetArea() methods.  
        foreach(Shape shape in shapes) { 
            string color = shape.GetColor();   
            Console.WriteLine(color); 

            double area = shape.GetArea(); // GetArea calls the appropriate depending 
                                           // what type is the overriden in the derived class.
            Console.WriteLine(area);  
        }

    }
}