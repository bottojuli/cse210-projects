using System; 

// Create the Fraction class.
public class Fraction 
{   
    // Attributes for the top and bottom numbers.
    private int _top; 
    private int _bottom; 

    // Constructors     
    // 1st constructor doesn't require any information. 
    public Fraction()  
    {  
        // Constructor that has no parameters that initializes the number to 1/1. 
        _top = 1; 
        _bottom = 1;
    }  
    // 2nd constructor accepts a value for one variable.
    public Fraction(int top) 
    {  
        // Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5,  
        // the fraction would be initialized to 5/1. 
        _bottom = 1;
    } 
    // 3rd constructor accepts values for the two variables.
    public Fraction(int top, int bottom) 
    { 
    }  
    // Create the Getters and Setters
    // Create getters and setters for both the top and the bottom values.
 
    public int GetTop() 
    { 
        return _top;
    }  
    public void SetTop(int top) { 
        _top = top;
    } 

    public int GetBottom() 
    { 
        return _bottom;
    }  
    public void SetBottom(int bottom) { 
        _bottom = bottom;
    }

    // Methods to return representations of both the fractional and decimal views.  
    // Create a method called GetFractionString that returns the fraction in the form 3/4. 
    public string GetFractionString()  
    {  
        return GetTop() + "/" + GetBottom();
    }
    // Create a method called GetDecimalValue that returns a double that is the result of dividing the top number  
    // by the bottom number, such as 0.75. 
    public double GetDecimalValue() 
    {  
        return Convert.ToDouble(_top) / Convert.ToDouble(_bottom);  
        // Other way to do the same:
        // return double(_top) / double(_bottom);
    }

}