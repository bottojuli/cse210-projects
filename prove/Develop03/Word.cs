using System;  
 
public class Word
{   
    // ATTRIBUTES 
    private string _word; 
    private bool _isHidden;

    // CONSTRUCTORS  
    public Word(string scriptureListItem) {  
        // Gives a value to the global _word variable.
        _word = scriptureListItem;  

        // This initializes the bool.
        _isHidden = false;
    } 

    // GETTERS AND SETTERS 
 
    public void SetHideWord(bool isHidden) {  
        this._isHidden = isHidden;
    }  
    public bool GetHideWord() {  // This canges its value when the SetHideWord is called and passed in a different value! (see Scripture class)
        return _isHidden;
    } 

    // It's a sort of "getter"
    public void ShowWord() {   
        // Ask the user to press the Enter key: 
        if(_isHidden == true) { 
            foreach(char letter in _word) { 
                Console.Write("_"); 
            }
        } 
        else { 
            Console.Write(_word);
        }
    }   

    // https://www.tutorialkart.com/c-sharp-tutorial/how-to-check-if-string-contains-specified-character-in-csharp/#:~:text=To%20check%20if%20a%20string,True%20if%20str%20contains%20value%20.
}