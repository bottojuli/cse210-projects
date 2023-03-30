using System;

class Program
{
    static void Main(string[] args)
    {
        int action = 0; 

        while (action != 5)   
        {   
            Console.WriteLine(""); 
            Console.WriteLine("Welcome to your Finances Calculator");
            Console.WriteLine(""); 
            Console.WriteLine("Menu:"); 
            Console.WriteLine("1) What are my monthly income taxes?");  
            Console.WriteLine("2) Final price after Sales Taxes");  
            Console.WriteLine("3) How much should I save per month?");   
            Console.WriteLine("4) How long will it take me to save X amount of money?");  
            Console.WriteLine("5) Quit");   
            Console.WriteLine("");

            Console.WriteLine("What would you like to do?");  
            action = Convert.ToInt32(Console.ReadLine());   
 
            // Monthly Income Taxes    
            if(action == 1 || action == 2)  
            {         
                // Ask for the nationality   
                Console.WriteLine("Citizenship: ");
                Console.WriteLine("1) Argentina citizen"); 
                Console.WriteLine("2) US citizen ");  

                int nationality = Convert.ToInt32(Console.ReadLine());                       
            
                if(action == 1)  
                {   
                    // Argentine citizens
                    if(nationality == 1) 
                    {   
                        // Create object from Argentine 
                        Argentine arg = new Argentine(); 
                        arg.CalculateIncomeTax(); 
                    }  
                    // US citizens
                    if(nationality == 2) 
                    {                    
                        // Create object from Argentine 
                        USCitizen usa = new USCitizen(); 
                        usa.CalculateIncomeTax();                    
                    }
                }    
                // Sales Taxes 
                if(action == 2)  
                {    
                    // Argentine citizens
                    if(nationality == 1) 
                    {    
                        // // Ask for price 
                        Console.WriteLine("Enter the price in argentine pesos ARG$: ");  
                        int  price = Convert.ToInt32(Console.ReadLine());    

                        // Create object from Argentine 
                        Argentine arg = new Argentine(); 
                        arg.CalculateSalesTax(price); 

                    }  
                    // US citizens
                    if(nationality == 2) 
                    {                    
                        // // Ask for salary 
                        Console.WriteLine("Enter the price in american dolars USD$: ");  
                        int price = Convert.ToInt32(Console.ReadLine());   

                        // Create object from Argentine 
                        USCitizen usa = new USCitizen(); 
                        usa.CalculateSalesTax(price);                   

                    }
                }    
            } 
            if(action == 3 || action == 4) 
            {                    
                // Ask the user for their kind of job  
                Console.WriteLine("Select the one that corresponds to you: "); 
                Console.WriteLine("1) Employee");
                Console.WriteLine("2) Entrepreneur"); 
                Console.WriteLine("3) Freelancer");  
                int jobOption = Convert.ToInt32(Console.ReadLine());  

                // Savings per month
                if(action == 3) 
                {      
                    Console.WriteLine("Enter the saving period of time in months: ");
                    int timeInMonths = Convert.ToInt32(Console.ReadLine());   
 
                    // Employee
                    if(jobOption == 1) 
                    {   
                        Console.WriteLine("Enter your monthly salary: ");
                        int salary = Convert.ToInt32(Console.ReadLine());  
                        
                        // Create object from Employed 
                        Employed employed = new Employed(timeInMonths, salary);
                        employed.CalculateSavings();
                    }  
                    // Entrepreneur
                    else if(jobOption == 2) 
                    {  
                        // Create object from Entrepreneur 
                        Entrepreneur entrepreneur = new Entrepreneur(timeInMonths);
                        entrepreneur.CalculateSavings();
                    }  
                    // Freelancer
                    else if(jobOption == 3) 
                    {   
                        // Create object from Freelancer 
                        Freelancer free = new Freelancer(timeInMonths);
                        free.CalculateSavings();
                    }
                }  
                // How long will it take to save X amount of money
                if(action == 4) 
                {  

                    // Employee
                    if(jobOption == 1) 
                    {  
                        // Create object from Employed 
                        Employed employed = new Employed();
                        employed.CalculateSavingTime();
                    }  
                    // Entrepreneur
                    else if(jobOption == 2) 
                    {  
                        // Create object from Entrepreneur 
                        Entrepreneur entrepreneur = new Entrepreneur();
                        entrepreneur.CalculateSavingTime();
                    }  
                    // Freelancer
                    else if(jobOption == 3) 
                    {  
                        // Create object from Freelancer 
                        Freelancer free = new Freelancer();
                        free.CalculateSavingTime();
                    }
                }                 
            } 
 
            // Quit
            if(action == 5) 
            { 
                break;
            }
        }
    } 


} 

// https://smartasset.com/taxes/factors-that-affect-income-tax