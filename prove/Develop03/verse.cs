class Verse
{
    private List<Word> _wordList = new List<Word>();
    public Verse(List<Word> wordList)
    {
        _wordList = wordList;
    }
    public void Display()
    {
        string verse = String.Join(" ", _wordList);
        Console.WriteLine(verse);
    }
    public int GetWordCount()
    {
        int wordCount = _wordList.Count();
        return wordCount;
    }
    public int GetRevealedCount(List<Word> _wordList)
    {
        return _wordList.Count(Word => Word._revealed == true);
    }
    public void HideWord(int index)
    {
        _wordList[index].Hide();
    }
    public void HideRandomWord()
    {
        Random rng = new Random();
        int random = rng.Next(GetWordCount());
        _wordList[random].Hide();
    }
}