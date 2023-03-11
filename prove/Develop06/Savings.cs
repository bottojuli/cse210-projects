using System;  
 
public abstract class Savings 
{   
    // Member variables 
    protected int _timeInMonths; 
    protected int _budget; 
    protected int _variableCosts; 
    protected double _salary; 

    protected double _decimal1;
 
    // Constructors 
    public Savings()
    { 
    } 
    public Savings(int timeInMonths, int salary)
    { 
        _timeInMonths = timeInMonths; 
        _salary = salary;
    }     
    public Savings(int timeInMonths)
    { 
        _timeInMonths = timeInMonths; 
    }   
 

    // Abstract methods 
    public abstract void CalculateSavings();

    public abstract void CalculateSavingTime(); 
 
    // Methods
    public double EnterDecimal() 
    {  
        // Ask the user to enter the decimal number 
        Console.WriteLine("Enter the percent of your salary you want to save: "); 
        double percent = Convert.ToInt32(Console.ReadLine());  
        _decimal1 = percent / 100;
        return _decimal1;
    }    

    public int EnterSalary()  
    {   
        Console.WriteLine("Enter your monthly salary: ");
        int salary = Convert.ToInt32(Console.ReadLine());  
         
        return salary;
    }  

    public int EnterMoney()  
    {   
        Console.WriteLine("Enter the amount of money you need to save: ");
        int money = Convert.ToInt32(Console.ReadLine());   
         
        return money;
    }  
}