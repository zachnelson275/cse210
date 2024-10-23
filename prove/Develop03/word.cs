using System.ComponentModel.DataAnnotations;

class Word
{
    public bool _revealed{ get; set; }
    private string _word;
    public void Display()
    {
        _revealed = true;
    }
    public void Hide()
    {
        _revealed = false;
        int length = _word.Length;
        _word = "";
        for (int i = 0; i < length; i++)
        {
            _word += "_";
        }
    }
    public bool IsRevealed()
    {
        if (_revealed == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Word(string word)
    {
        _word = word;
        _revealed = true;
    }
}