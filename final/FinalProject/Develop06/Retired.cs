using System; 
 
public class Retired: Taxes 
{  
    // Constructor
    public Retired():  
            base() 
    { 
    } 
    
    // Overriden method 
    public override void CalculateSalesTax(int price)
    {  
        // For retired people the operation is different; they have discount rather than tax
        _finalPrice = _price - ((1 + Convert.ToInt32(_decimalFactor)) * _price);  
        Console.WriteLine($"The final price is: ${_finalPrice}");
    } 

    public override void CalculateIncomeTax() 
    {    
        Console.Write("Enter your monthly salary in argentinian pesos (ARS$): "); 
        _salary = Convert.ToInt32(Console.ReadLine());   
                
        // Pay taxes
        if(_incomeTax > 500000) 
        {   
            _decimalFactor = 0.35; 
            _incomeTax = (_salary * _decimalFactor) + 71400;
        }   
        //  Don't pay taxes
        else
        {  
            _incomeTax = 0;
        } 
        Console.WriteLine($"The final price is: ${_incomeTax}");
    }     
}