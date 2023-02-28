using System; 
// Make sure this class inherits from the base class. 
public class Circle: Shape  
{   
    // Create the _radius attribute as a private member variable. 
    private double _radius; 
    
    // Create a constructor that accepts the color and the side, and then call the base  
    // constructor with the color. 
    public Circle(string color, double radius): base(color) {  
        // set the _side variable 
        _radius = radius;  
    } 

    // Override the GetArea() method from the base class and fill in the body of this function  
    // to return the area.
    public override double GetArea() {  
        // This virtual keyword tells C# that I could override this in other classes.  
        double area = (Math.PI)*(_radius * _radius);
        return area;
    }
} 