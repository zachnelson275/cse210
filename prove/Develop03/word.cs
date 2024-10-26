using System.ComponentModel.DataAnnotations;

class Word
{
    public bool _revealed{ get; set; }
    private string _word;
    public void Display()
    {
        Console.Write(_revealed ? _word : new string('_', _word.Length));
    }
    public void Hide()
    {
        _revealed = false;
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