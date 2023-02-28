using System; 
// Make sure this class inherits from the base class. 
public class Square: Shape  
{   
    // Create the _side attribute as a private member variable. 
    private double _side;
    
    // Create a constructor that accepts the color and the side, and then call the base  
    // constructor with the color. 
    public Square(string color, double side): base(color) {  
        // set the _side variable 
        _side = side;  
    } 

    // Override the GetArea() method from the base class and fill in the body of this function  
    // to return the area.
    public override double GetArea() {  
        // This virtual keyword tells C# that I could override this in other classes.  
        double area = _side * _side;
        return area;
    }
} 

