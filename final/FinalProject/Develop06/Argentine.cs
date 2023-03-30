using System; 
 
// https://www.iprofesional.com/impuestos/373195-afip-ganancias-como-se-calcula-el-monto-y-porcentaje
public class Argentine: Taxes 
{  
    // Attributes 
    private int _plus;  

    // Constructor 
    public Argentine():  
            base() 
    {  
    }

    public override void CalculateIncomeTax()
    {     
        // Ask for salary 
        Console.WriteLine("Enter your monthly salary in argentine pesos ARG$: ");  
        int salary = Convert.ToInt32(Console.ReadLine());  

        if(salary < 20000) 
        {
            _plus = 0;  
            _decimalFactor = 0.05;  
        } 
        else if(salary > 20000 && salary < 40000) 
        {
            _plus = 1000; 
            _decimalFactor = 0.09; 
        } 
        else if(salary > 40000 && salary < 60000) 
        {
            _plus = 2800;  
            _decimalFactor = 0.12; 
        } 
        else if(salary > 60000 && salary < 80000) 
        {
            _plus = 5200;  
            _decimalFactor = 0.15; 
        } 
        else if(salary > 80000 && salary < 120000) 
        {
            _plus = 8200;  
            _decimalFactor = 0.19; 
        } 
        else if(salary > 120000 && salary < 160000) 
        {
            _plus = 15800;  
            _decimalFactor = 0.23;    
        } 
        else if(salary > 160000 && salary < 240000) 
        { 
            _plus = 25000;  
            _decimalFactor = 0.27;
        } 
        else if(salary > 240000 && salary < 320000) 
        {
            _plus = 46000;  
            _decimalFactor = 0.31;
        } 
        else 
        {
            _plus = 71400;  
            _decimalFactor = 0.35;
        } 
        _incomeTax = (salary * _decimalFactor) + _plus;   
 
        Console.WriteLine();
        Console.WriteLine($"The income tax is: ${_incomeTax}");
    }



     
}