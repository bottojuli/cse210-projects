using System; 

public class Employed: Savings 
{  
    // Constructors 
    public Employed(int timeInMonths, int salary): 
           base(timeInMonths, salary)     
    {
    }     
    public Employed(): 
           base()     
    {
    } 
 
    // Overriden methods
    public override void CalculateSavings()
    {  
        double decimalFactor = EnterDecimal();
        double savings = (decimalFactor * _salary); 
        
        Console.WriteLine($"You will have to save ${savings} every month to reach your goal in {_timeInMonths} months."); 
        Console.WriteLine($"You will save a total of: ${savings * _timeInMonths}."); 
        Console.WriteLine();
    } 

    public override void CalculateSavingTime()
    {    
        int money = EnterMoney(); 
        int salary = EnterSalary();
        double decimalFactor = EnterDecimal(); 

        double time = money/(salary * decimalFactor);
        Console.WriteLine($"You will need {time} months in order to save {money}"); 
        Console.WriteLine();
    } 

} 