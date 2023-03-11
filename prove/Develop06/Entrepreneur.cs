using System; 

public class Entrepreneur: Savings 
{  

    // Constructors
    // Constructor for CalculateSavings()
    public Entrepreneur(int timeInMonths, int salary): 
           base(timeInMonths, salary)     
    {
    }   
    public Entrepreneur(int timeInMonths): 
        base(timeInMonths)     
    {
    }  
    public Entrepreneur(): 
           base()     
    {
    }   

    // Methods 
    public override void CalculateSavings()
    {    
        double decimalFactor = (EnterDecimal());
        // This subtracts the fixed costs from the business
        double savings = (decimalFactor * CalculateRealIncome());
        Console.WriteLine($"You will have to save ${savings} every month to reach your goal in {_timeInMonths} months."); 
        Console.WriteLine($"You will save a total of: ${savings * _timeInMonths}.");  
        Console.WriteLine();
    } 

    public override void CalculateSavingTime()
    {     
        double decimalFactor = (EnterDecimal()); 
        int money = EnterMoney(); 

        double time = money/(CalculateRealIncome()  * decimalFactor);
        Console.WriteLine($"You will need {time} months in order to save ${money}"); 
        Console.WriteLine();
    } 

    // Private method
    private int CalculateRealIncome()
    {    
        // Ask the average income of the business (which is only how much earns, before subtracting the fixed costs)
        Console.WriteLine("Enter your average monthly income: "); 
        int averageIncome = Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine("Enter the fixed monthly costs of your business: ");  
        int fixedCosts = Convert.ToInt32(Console.ReadLine()); 

        int realIncome = averageIncome - fixedCosts;
        return realIncome;
    }       
} 