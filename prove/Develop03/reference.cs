class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public void displayReference()
    {
        if (_endVerse != 0)
        {
            Console.Write($"{_book} {_chapter}: {_startVerse}-{_endVerse}");
        }
        else 
        {
            Console.Write($"{_book} {_chapter}: {_startVerse}");

        }
    }
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
    }
}