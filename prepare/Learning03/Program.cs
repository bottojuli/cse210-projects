using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");  

        // In your Program.cs file, verify that you can create fractions using all three of these constructors.  
        // For example, create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor),  
        // for 6/7 (using the third constructor). 
        Fraction fraction1 = new Fraction(); // I create an instance of the Fraction class
        Fraction fraction2 = new Fraction(1); // I create an instance of the Fraction class  

        Fraction fraction3 = new Fraction(6, 7); // I create an instance of the Fraction class

        // In your Program.cs file, verify that you can call all of these methods and get the correct values, using  
        // setters to change the values and then getters to retrieve these new values and then display them to the  
        // console.   
        // fraction1.SetTop(3); 
        // Console.WriteLine(fraction1.GetTop());   
        // fraction1.SetBottom(3); 
        // Console.WriteLine(fraction1.GetBottom()); 

        // Verify that you can call each constructor and that you can retrieve and display the different representations  
        // for a few different fractions. For example, you could try:  
        fraction1.SetTop(1); 
        fraction1.SetBottom(1);
        Console.WriteLine(fraction1.GetFractionString()); 
        Console.WriteLine(fraction1.GetDecimalValue());   

        fraction1.SetTop(5); 
        fraction1.SetBottom(1);
        Console.WriteLine(fraction1.GetFractionString());  
        Console.WriteLine(fraction1.GetDecimalValue());  

        fraction1.SetTop(1); 
        fraction1.SetBottom(1);
        Console.WriteLine(fraction1.GetFractionString()); 
        Console.WriteLine(fraction1.GetDecimalValue());   

        fraction1.SetTop(1); 
        fraction1.SetBottom(3);
        Console.WriteLine(fraction1.GetFractionString());  
        Console.WriteLine(fraction1.GetDecimalValue()); 

    }
} 
