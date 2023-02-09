using System;

public class Scripture
{
    // The scriptures string variable is in the Program.cs file. It will be passed when called in order to generate 
    // the array in ConvertStringToList. 
    // private List<string> _scriptureList = new List<string>(); 
    // Attribute that represents the string of scriptures  

    private string _scripturesString = "";

    // I create a list from the Word class. It has items of Word data type.
    private List<Word> _listOfWords = new List<Word>();

    // I declare a public instance for Reference inside of the Scripture class so I can call it inside of Program
    public Reference rfr = new Reference();



    // CONSTRUCTORS 
    public Scripture()
    {
    }

    public Scripture(string reference, string scripture)
    {
        rfr.SetReference(reference);
        // Call the SetScripture so that the _scripturesString gets the actual value I'm setting.
        SetScripture(scripture);
    }


    // GETTERS AND SETTERS:
    // We need to set the scripture in order to be able to use it in the Program: 
    // This method is called in the Scripture constructor.
    public void SetScripture(string strScripture)
    {
        _scripturesString = strScripture;

        // Creates a list for each different scripture in the .txt file:
        string[] _wordsArray = _scripturesString.Split(" ");

        // Append words to the _listOfWords 
        foreach (string word in _wordsArray)
        {
            // Create a Word object to call the constructor from Word class.
            Word wrd = new Word(word);

            //_listOfWords[index] is a Word object.
            _listOfWords.Add(wrd); // It should add the wrd since it was declared to contain only Word data type. 
        }
    }

    // METHODS
    public List<Word> GetShownWords()
    {
        List<Word> words = new List<Word>();
        foreach (Word word in _listOfWords)
        {
            if (word.GetHideWord() == false)
            {
                words.Add(word);
            }
        }
        return words;
    }

    public void DisplayWords()
    {
        foreach (Word word in _listOfWords)
        {
            // It prints words or _, depending on what _isHidden takes as a bool value.
            word.ShowWord();

            // Add white spaces between words.
            Console.Write(" ");
        }
    }


    // This method is only called when the state returned from the CheckFullyHidden method is "true".
    public void HideWords()
    {
        // Create an instance of the Random class
        Random rnd = new Random();
        // // This displays the scripture without hiding the words yet.
        // DisplayWords();  

        // This loop is executed until the CheckFullyHidden changes the state variable to true, which means that the list is totally hidden.
        while (true)
        {
            int counter = 0; 

            if (counter == 0)
            {
                Console.Clear();
            } 
            
            // This method allows me to work only with the words that are still shown and NOT hidden. 
            List<Word> words = new List<Word>();
            foreach (Word word in _listOfWords)
            {
                if (word.GetHideWord() == false)
                {
                    words.Add(word);
                }
            }
            foreach (Word word in _listOfWords)
            {

                word.ShowWord();

                // Add white spaces between words.
                Console.Write(" ");
            }

            // White space 
            Console.WriteLine();

            // It's executed three times, in order to hide three words: 
            while (counter < 3)
            {
                // Select three random words to hide 
                int index = rnd.Next(words.Count() - 1); // I substract 1 unit because the index  
                                                         // is a number less than the length of the array.
                // Get a Word object from the Word list 
                words[index].SetHideWord(true); // Changes the isHidden to true to indicate a hidden word.

                counter++; 
            } 

            // If GetHideWord() is false, the state will be TRUE, so the while breaks and the  
            // program ends.
            bool state =  false; 
            // This executes every time we press enter, and reviews the whole scripture to see if all 
            // the words are gone or not.
            foreach (Word word in _listOfWords)
            {
                if (word.GetHideWord() == false)
                {
                    state = true;
                }
                else
                {
                    state =  false;
                }
            } 

            // if the return value of checkfullyhidden is true then we break the while.
            if (state == false)
            {
                break; // Ends executing the method automatically.
            } 

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or Quit to finish.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break; // Ends executing the method.
            }
            // This line deletes the previous selected scripture with its deleted words to that  
            // point.
            Console.Clear();
        }
    }

}

// https://www.geeksforgeeks.org/c-sharp-how-to-check-whether-a-list-contains-a-specified-element/   

// using System;  

// public class Scripture 
// {  
//     // The scriptures string variable is in the Program.cs file. It will be passed when called in order to generate 
//     // the array in ConvertStringToList. 
//     // private List<string> _scriptureList = new List<string>(); 
//     // Attribute that represents the string of scriptures  

//     private string _scripturesString = ""; 

//     // I create a list from the Word class. It has items of Word data type.
//     private List<Word> _listOfWords = new List<Word>();
//     List<Word> words = new List<Word>();
//     // I declare a public instance for Reference inside of the Scripture class so I can call it inside of Program
//     public Reference rfr = new Reference();  



//     // CONSTRUCTORS 
//     public Scripture() { 
//     } 

//     public Scripture(string reference, string scripture) { 
//         rfr.SetReference(reference);  
//         // Call the SetScripture so that the _scripturesString gets the actual value I'm setting.
//         SetScripture(scripture);
//     }


//     // GETTERS AND SETTERS:
//     // We need to set the scripture in order to be able to use it in the Program: 
//     // This method is called in the Scripture constructor.
//     public void SetScripture(string strScripture) { 
//         _scripturesString = strScripture;   

//         // Creates a list for each different scripture in the .txt file:
//         string[] _wordsArray = _scripturesString.Split(" "); 

//         // Append words to the _listOfWords 
//         foreach(string word in _wordsArray) {  
//             // Create a Word object to call the constructor from Word class.
//             Word wrd = new Word(word);   

//             //_listOfWords[index] is a Word object.
//             _listOfWords.Add(wrd); // It should add the wrd since it was declared to contain only Word data type. 
//         }
//     }  
//     public List<string> GetRenderedText() {  
//         return null;
//     }


//     // METHODS
//     public bool CheckFullyHidden() {    
//         // word is a temporary object from the Word class created within the conditions of the foreach loop.  
//         foreach(Word word in _listOfWords) {  
//             // Call the GetHideWord from the Word class in order to check if it is ?????????
//             if(word.GetHideWord() == false) { 
//                 return false; 
//             }  
//         } 
//         return true;
//     }  

//     public List<Word> GetShownWords(){
//         foreach (Word word in _listOfWords)
//         {
//             if (word.GetHideWord() == false){
//                 words.Add(word); 
//                 // Do I need to call the SetHideWord inside in order to filter the hidden words?
//             }
//         }
//         return words;
//     }

//     public void DisplayWords(){
//         foreach(Word word in _listOfWords) {     

//                 // It prints words or _.
//                 word.ShowWord(); 

//                 // Add white spaces between words.
//                 Console.Write(" ");
//             } 
//     }


//     // This method is only called when the state returned from the CheckFullyHidden method is "true".
//     public void HideWords() {   
//         Console.Clear(); 
//         // Create an instance of the Random class
//         Random rnd = new Random();   
//         // This displays the scripture without hiding the words yet.
//         // DisplayWords();  

//         // This loop is executed until the CheckFullyHidden changes the state variable to true, which means that the list is totally hidden.
//         while(true) {     
//             int counter = 0;   

//             // Delete everything in the terminal window 
//             // Console.Clear(); 

//             // Display the chosen scripture.
//             DisplayWords(); 

//             // White space 
//             Console.WriteLine(); 

//             // This method allows me to work only with the words that are still shown and NOT hidden. 
//             GetShownWords();

//             // It's executed three times, in order to hide three words: 

//              { 

//                 // Select three random words to hide 
//                 int index = rnd.Next(words.Count() - 1); // I substract 1 unit because the index is a number less than the length of the array.

//                 // Get a Word object from the Word list 
//                 words[index].SetHideWord(true);  
//                 counter++;

//             } 
//             // Call the ShowWord() to display the words.   
//             // DisplayWords();  

//             // Call the CheckFullyHidden() to see if its returning value is true and we can finish executing the while.
//             bool state = CheckFullyHidden(); 
//             // if the return value of checkfullyhidden is true then we break the while.
//             if(state == true) { 
//                 break;
//             }   
//             Console.WriteLine();
//             Console.WriteLine("Press Enter to continue or Quit to finish."); 
//             string userInput = Console.ReadLine();   

//             if(userInput.ToLower() == "quit") { 
//                 break; // Ends executing the method.
//             }  
//             Console.Clear(); 
//             DisplayWords();   

//             // The problem is that the GetShownWords is not working well. The enter is pressed the number  
//             // of words in the scripture and then quits automatically, even if it didn't take off all the words.
//         }
//     }

// } 