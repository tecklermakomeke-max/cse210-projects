// This class stores the whole scripture and list of words
public class Scripture
{
    private Reference _reference;
    private List<Word> _words; 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');
        foreach (string p in parts)
        {
            _words.Add(new Word(p));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            List<Word> notHidden = _words.Where(w =>!w.IsHidden()).ToList();
            if (notHidden.Count == 0) break; // all hidden already

            int index = rand.Next(notHidden.Count);
            notHidden[index].Hide();
        }
    }

    public string GetDisplay()
    {
        string display = _reference.GetText() + " ";
        foreach (Word w in _words)
        {
            display += w.GetDisplay() + " ";
        }
        return display;
    }

    // Check if all words are hidden
    public bool IsAllHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) return false;
        }
        return true;
    }
}