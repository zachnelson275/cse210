class Verse
{
    private List<Word> _wordList = new List<Word>();
    public int GetWordCount()
    {
        int wordCount = _wordList.Count();
        return wordCount;
    }
    public int GetRevealedCount(List<Word> _wordList)
    {
        return _wordList.Count(Word => Word._revealed == true);
    }
    public void HideRandomWord()
    {
        
    }
}