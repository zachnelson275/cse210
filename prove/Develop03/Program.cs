using System;

class Program
{
    static void Main(string[] args)
    {
        List<Word> verse16Words = new List<Word>
        {
            new Word("For"), 
            new Word("God"), 
            new Word("so"), 
            new Word("loved"), 
            new Word("the"), 
            new Word("world,"),
            new Word("that"), 
            new Word("he"), 
            new Word("gave"), 
            new Word("his"), 
            new Word("only"), 
            new Word("begotten"), 
            new Word("Son,"), 
            new Word("that"), 
            new Word("whosoever"), 
            new Word("believeth"), 
            new Word("in"), 
            new Word("him"), 
            new Word("should"), 
            new Word("not"), 
            new Word("perish,"), 
            new Word("but"), 
            new Word("have"), 
            new Word("everlasting"), 
            new Word("life"), 
        };

        List<Word> verse17Words = new List<Word>
        {
            new Word("For"), 
            new Word("God"), 
            new Word("sent"), 
            new Word("not"), 
            new Word("his"), 
            new Word("Son"), 
            new Word("into"), 
            new Word("the"), 
            new Word("world"), 
            new Word("to"), 
            new Word("condemn"), 
            new Word("the"), 
            new Word("world;"), 
            new Word("but"), 
            new Word("that"), 
            new Word("the"), 
            new Word("world"), 
            new Word("through"), 
            new Word("him"), 
            new Word("might"), 
            new Word("be"), 
            new Word("saved"), 
        };

        Verse verse16 = new Verse(verse16Words);
        Verse verse17 = new Verse(verse17Words);

        List<Verse> verses = new List<Verse> { verse16, verse17 };
        Reference reference = new Reference("John", 3, 16, 17);
        Scripture scripture = new Scripture(reference, verses);

        int verse16Revealed = verse16.GetRevealedCount();
        int verse17Revealed = verse17.GetRevealedCount();

        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorizer! Press Enter to continue, or type 'quit' to quit");
        Console.WriteLine();

        while (verse16Revealed + verse17Revealed > 0)
        {
            scripture.Display();
            string next = Console.ReadLine();

            if (next == "quit")
            {
                break;
            }

            Console.Clear();
            Console.WriteLine("Press Enter to continue, or type 'quit' to quit");
            Console.WriteLine();
            
            scripture.HideThreeRandomWords();
            verse16Revealed = verse16.GetRevealedCount();
            verse17Revealed = verse17.GetRevealedCount();
        }
    }
}