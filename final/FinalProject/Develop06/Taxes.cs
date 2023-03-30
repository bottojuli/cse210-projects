using System; 

public abstract class Taxes 
{ 
   // Member variables 
   protected double _decimalFactor;  
   protected double _incomeTax;
   protected double _finalPrice;  
   protected int _price;   
   protected int _salary;
   protected int _cardCompany; // The user chooses from a displaying list 
   protected int _nationality; // The user chooses from a displaying list


    // Constructor
    public Taxes() 
    { 
    }   
   

    // Abstract method 
    public abstract void CalculateIncomeTax();
    
    // Virtual method  
    // Overriden only in Retired
    public virtual void CalculateSalesTax(int price) 
    {  
        Console.WriteLine("Do you live in... "); 
        Console.WriteLine("1) A big/urbanized city");  
        Console.WriteLine("2) An urbanized/small city");  
        Console.WriteLine("3) A rural/less urbanized city");  

        int option = Convert.ToInt32(Console.ReadLine()); 
        if(option == 1) 
        {  
            _decimalFactor = 1.15;
        }   
        if(option == 2) 
        {  
            _decimalFactor = 1.10;
        }  
        if(option == 3) 
        {  
            _decimalFactor = 1.7;
        }  
        Console.WriteLine(); 

        _finalPrice = (_decimalFactor) * price;  
        Console.WriteLine($"The final price is: ${_finalPrice}"); 
        Console.WriteLine(); 
    } 



}