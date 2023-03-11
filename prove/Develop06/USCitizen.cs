using System; 
 
public class USCitizen: Taxes 
{ 
    // Attributes 
    private int _maritalStatus;
    // Constructor
    public USCitizen():  
            base() 
    {     
    }

    // Methods 
    public override void CalculateIncomeTax()
    {     
        // Ask for salary 
        Console.WriteLine("Enter your monthly salary in american dolars USD$: ");  
        int _salary = Convert.ToInt32(Console.ReadLine());  

        _salary = _salary * 12;      
 
        Console.WriteLine();
        Console.WriteLine("Select your marital status:"); 
        Console.WriteLine("1) Single"); 
        Console.WriteLine("2) Married Filing Jointly"); 
        Console.WriteLine("3) Married Filing Separately"); 
        Console.WriteLine("4) Head Of Household"); 
        _maritalStatus = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine();  
 
        // Single
        if(_maritalStatus == 1)
        {     
            // 10%
            if(_salary < 10275) 
            {    
                _incomeTax = _salary * 0.1;
            }
            // 12%
            else if(_salary > 10276 && _salary < 41775) 
            {    
                _incomeTax = _salary * 0.12;
            }
            // 22%
            else if(_salary > 41776 && _salary < 89075) 
            {    
                _incomeTax = _salary * 0.22;
            } 
            // 24%
            else if(_salary > 89076 && _salary < 170050) 
            {    
                _incomeTax = _salary * 0.24;
            }
            // 32%
            else if(_salary > 170051 && _salary < 215950) 
            {    
                _incomeTax = _salary * 0.32;
            }
            // 35%
            else if(_salary > 215951 && _salary < 539900) 
            {    
                _incomeTax = _salary * 0.35;
            }
            // 37%
            else if(_salary > 539901) 
            {    
                _incomeTax = _salary * 0.37;
            } 

        }   
        // Married Filing Jointly
        else if(_maritalStatus == 2)
        {    
            // 10%
            if(_salary < 20550) 
            {    
                _incomeTax = _salary * 0.1;
            }  
            // 12%
            else if(_salary > 20551 && _salary < 83550) 
            {    
                _incomeTax = _salary * 0.12;
            }
            // 22%
            else if(_salary > 83551 && _salary < 178150) 
            {    
                _incomeTax = _salary * 0.22;
            } 
            // 24%
            else if(_salary > 178151 && _salary < 340100) 
            {    
                _incomeTax = _salary * 0.24;
            }
            // 32%
            else if(_salary > 340101 && _salary < 431900) 
            {    
                _incomeTax = _salary * 0.32;
            }
            // 35%
            else if(_salary > 431901 && _salary < 647850) 
            {    
                _incomeTax = _salary * 0.35;
            }
            // 37%
            else if(_salary > 647851) 
            {    
                _incomeTax = _salary * 0.37;
            }
        }  
        // Married Filing Separately
        else if(_maritalStatus == 3)
        {    
            // 10%
            if(_salary < 10275) 
            {    
                _incomeTax = _salary * 0.1;
            }  
            // 12%
            else if(_salary > 10276 && _salary < 41775) 
            {    
                _incomeTax = _salary * 0.12;
            }
            // 22%
            else if(_salary > 41776 && _salary < 89075) 
            {    
                _incomeTax = _salary * 0.22;
            } 
            // 24%
            else if(_salary > 89076 && _salary < 170050) 
            {    
                _incomeTax = _salary * 0.24;
            }
            // 32%
            else if(_salary > 170051 && _salary < 215950) 
            {    
                _incomeTax = _salary * 0.32;
            }
            // 35%
            else if(_salary > 215951 && _salary < 539900) 
            {    
                _incomeTax = _salary * 0.35;
            }
            // 37%
            else if(_salary > 539901) 
            {    
                _incomeTax = _salary * 0.37;
            } 

        }   
        // Head Of Household
        else if(_maritalStatus == 4)
        {    
            // 10%
            if(_salary < 14650) 
            {    
                _incomeTax = _salary * 0.1;
            } 

            // 12%
            else if(_salary > 14651 && _salary < 55900) 
            {    
                _incomeTax = _salary * 0.1;
            } 
            // 22%
            else if(_salary > 55901 && _salary < 89050) 
            {    
                _incomeTax = _salary * 0.22;
            } 
            // 24%
            else if(_salary > 89051 && _salary < 170050) 
            {    
                _incomeTax = _salary * 0.24;
            }
            // 32%
            else if(_salary > 170051 && _salary < 215950) 
            {    
                _incomeTax = _salary * 0.32;
            }
            // 35%
            else if(_salary > 215951 && _salary < 539900) 
            {    
                _incomeTax = _salary * 0.35;
            }
            // 37%
            else if(_salary > 539901) 
            {    
                _incomeTax = _salary * 0.37;
            }
        }   
        Console.WriteLine();
        Console.WriteLine($"The income tax is: ${_incomeTax}");
    } 

    
    // https://smartasset.com/taxes/factors-that-affect-income-tax
    
}