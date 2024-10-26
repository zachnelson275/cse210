class Reference
{
    private string _book { get; set;}
    private int _chapter { get; set;}
    private int _startVerse { get; set; }
    private int _endVerse { get; set; }
    public void Display()
    {
        if (_endVerse != 0)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
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
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

}