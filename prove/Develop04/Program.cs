using System; 

/* Stretch Challenge: 
For the stretch challenge I choose to save and load from a .txt file. The user is 
prompted to enter the .txt file name. There is a new option inside the menu where the user 
can load the .txt file. By this way, the user can load the current or previous files.  
*/
 
 
class Program
{
    static void Main(string[] args)
    {     
        int optionIndex = 0; 
        
        // While loop that runs the progrom until the user decides to quit 
        while(true) 
        { 
            // Display activity menu and let the user select one. 
            List<string> list = new List<string>(){
                "1) Breathing",
                "2) Reflecting",
                "3) Listing", 
                "4) Quit", 
                "5) Load entry file"
            };
            
            foreach(string item in list) 
            { 
                Console.WriteLine(item); 
            } 

            Console.WriteLine();
            Console.Write("Choose one activity: ");   
            optionIndex = Convert.ToInt32(Console.ReadLine());

            if(optionIndex == 1) 
            { 
                // Breathing Activity:
                Console.Write("Enter the duration (seconds): ");
                int duration = Convert.ToInt32(Console.ReadLine());
                Breathing breathing = new Breathing(duration);
                breathing.RunBreathing();
            } 
            else if(optionIndex == 2) 
            {  
                // Reflecting Activity:
                Console.Write("Enter the duration (seconds): ");
                int duration = Convert.ToInt32(Console.ReadLine());
                Reflecting reflecting = new Reflecting(duration);
                reflecting.RunReflecting();

            }  
            else if(optionIndex == 3) 
            {  
                // Listing Activity:
                int duration = 0;
                Listing listing = new Listing(duration);
                listing.RunListing();
            }   
            else if(optionIndex == 5) 
            {  
                // Listing Activity:
                int duration = 0;
                Listing listing = new Listing(duration);
                listing.LoadFile();
            } 
            else if(optionIndex == 4) 
            { 
                break;
            }
        }  
    }
}