
public class Word
{
    private string _text; 
    private bool _hidden; 

    public Word(string text)
    {
        _text = text;
        _hidden = false; 
    }

    // Hide this word
    public void Hide()
    {
        _hidden = true;
    }

    // Check if hidden
    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetDisplay()
    {
        if (_hidden)
            return new string('_', _text.Length); 
        else
            return _text;
    }
}