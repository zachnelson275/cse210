
using System.ComponentModel.DataAnnotations;

class Scripture
{
    private Reference _scriptureReference;
    private List<Verse> _verses = new List<Verse>();

    public Scripture(Reference reference, List<Verse> verses)
    {
        _scriptureReference = reference;
        _verses = verses;
    }
    public void Display()
    {
        _scriptureReference.displayReference();
        Console.WriteLine();
        foreach (var verse in _verses)
        {
            verse.Display();
        }
    }
    public void HideThreeRandomWords()
    {
        foreach (var verse in _verses)
        {
            for (int i = 0; i < 3; i++)
            {
                verse.HideRandomWord();
            }
        }
    }
}