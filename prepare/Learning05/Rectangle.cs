using System; 
// Make sure this class inherits from the base class. 
public class Rectangle: Shape  
{   
    // Create the _length and _width attributes as a private member variables. 
    private double _length; 
    private double _width;
    
    // Create a constructor that accepts the color and the side, and then call the base  
    // constructor with the color. 
    public Rectangle(string color, double length, double width): base(color) {  
        // set the _length and _width variables 
        _length = length;   
        _width = width;
    } 

    // Override the GetArea() method from the base class and fill in the body of this function  
    // to return the area.
    public override double GetArea() {  
        // This virtual keyword tells C# that I could override this in other classes.  
        double area = _length * _width;
        return area;
    }
} 