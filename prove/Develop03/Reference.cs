using System; 
 
public class Reference
{    
    // ATTRIBUTES FROM THE CLASS. 
    // They are all setted to private.
    private string _referenceString = "";  
    private string _book; 
    private string _chapter; 
    private string _verse1; 
    private string _verse2;

    // CONSTRUCTORS  
    public Reference() { 
    } 
    public Reference(string verse1) { 
        _verse1 = verse1; 
        _verse2 = null;
    } 
    public Reference(string verse1, string verse2) { 
        _verse1 = verse1; 
        _verse2 = verse2;
    } 

    public void SetReference(string strReference) { 
        _referenceString = strReference;
    }  

    public string GetReference() {   
        if(_verse2 != null) { 
            _referenceString = $"{_book} {_chapter}:{_verse1}-{_verse2}";
        } 
        else { 
            _referenceString = $"{_book} {_chapter}:{_verse1}";
        }
        return _referenceString; 
    } 


}
