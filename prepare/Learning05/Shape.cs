using System;
 
// This class MUST be declared as an abstract class, since we used an abstract method later.
public abstract class Shape 
{  
    // Add the color member variable and a getter and setter for it.
    protected string _color;  

    // Create a constructor that accepts the color and set its.
    public Shape(string color) {  
        _color = color;
    } 
    public string GetColor() { 
        return _color;
    } 
    public void SetColor(string color) { 
        _color = color;
    } 

    // Create a virtual method for GetArea().   
    // Step 4: Override the GetArea() method from the base class and fill in the body of this  
    // function to return the area. 

    // public virtual double GetArea() {  
    //     // This virtual keyword tells C# that I could override this in other classes. 
    //     return 1;
    // } 

    // Replace the virtual keyword by an abstract keyword. This measn that it's an empty virtual  
    // function that must be "filled in" by any class that inherits from Shape. Then, any class 
    // that has an abstract method must also be declared to be abstract.
    public abstract double GetArea();
}