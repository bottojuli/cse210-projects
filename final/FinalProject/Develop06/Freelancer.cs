using System; 

public class Freelancer: Savings 
{ 
    // Constructor for CalculateSavings()
    public Freelancer(int timeInMonths, int salary): 
           base(timeInMonths, salary)     
    {
    }  
    public Freelancer(int timeInMonths): 
           base(timeInMonths)     
    {
    }    
    public Freelancer(): 
           base()     
    {
    } 
 
    // Overriden methods
    public override void CalculateSavings()
    {   
        double decimalFactor = (EnterDecimal());
        double savings = (decimalFactor * (CalculateIncome()));
        Console.WriteLine($"You will have to save ${savings} every month to reach your goal in {_timeInMonths} months."); 
        Console.WriteLine($"You will save a total of: ${savings * _timeInMonths}.");  
        Console.WriteLine();
    } 

    public override void CalculateSavingTime()
    {  
        double decimalFactor = (EnterDecimal()); 
        int money = EnterMoney(); 
        int salary = EnterSalary(); 

        double time = money/((CalculateIncome()) * decimalFactor);
        Console.WriteLine($"You will need {time} months in order to save {money} (saving a {decimalFactor}% of your salary)"); 
        Console.WriteLine();
    } 
 
    // Private method
    private int CalculateIncome()
    { 
        // Ask the average number of clients per month
        Console.WriteLine("Enter the average number of clients per month: "); 
        int averageClients = Convert.ToInt32(Console.ReadLine());  

        // Ask the average number of clients per month
        Console.WriteLine("Enter the cost of your service: "); 
        int incomePerClient = Convert.ToInt32(Console.ReadLine());  
 
        int income = averageClients * incomePerClient;
        return income;
    }
} 