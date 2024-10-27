public class Reference
{

    // Attributes
    private string _chapter;
    private string _book;
    private List<string> _verses;
    private int _versesToLearn;
    private int _randomVerse;

    // Constructors
    public Reference()
    {
        _chapter = "The Book Of Mormon";
        _book = "Title Page";
        _verses = ["Wherefore, it is an abridgment of the record of the people of Nephi, and also of the Lamanites Written to the Lamanites, who are a remnant of the house of Israel; and also to Jew and Gentile Written by way of commandment, and also by the spirit of prophecy and of revelation Written and sealed up, and hid up unto the Lord, that they might not be destroyed To come forth by the gift and power of God unto the interpretation thereof Sealed by the hand of Moroni, and hid up unto the Lord, to come forth in due time by way of the Gentile The interpretation thereof by the gift of God.", "An abridgment taken from the Book of Ether also, which is a record of the people of Jared, who were scattered at the time the Lord confounded the language of the people, when they were building a tower to get to heaven Which is to show unto the remnant of the house of Israel what great things the Lord hath done for their fathers; and that they may know the covenants of the Lord, that they are not cast off forever And also to the convincing of the Jew and Gentile that Jesus is the Christ, the Eternal God, manifesting himself unto all nations And now, if there are faults they are the mistakes of men; wherefore, condemn not the things of God, that ye may be found spotless at the judgment seat of Christ."];
    }

    public Reference(string chapter, string book, List<string> verses)
    {
        _chapter = chapter;
        _book = book;
        _verses = verses;
    }

    // Behaviors

    // displays the verse reference with multiple verses if needed
    public void DisplayReference()
    {
        
        if (_versesToLearn > 1)
        {
           Console.Write($"{_chapter} {_book}:{_randomVerse+1}-{_randomVerse+_versesToLearn} ");
        }
        else
        {
            Console.Write($"{_chapter} {_book}:{_randomVerse+1} ");
        }
    }

    public List<string> SelectRandomVerse()
    {
        List<string> verseReference = new();

        Console.WriteLine("How many verses would you like to memorize?");
        _versesToLearn = int.Parse(Console.ReadLine());

        Random random = new();
        _randomVerse = random.Next(1,_verses.Count);
        

        // Ensure the user does not ask for more verses than available
        if (_versesToLearn > _verses.Count)
        {
            Console.WriteLine("Not enough verses available. Showing all available verses.");
            _versesToLearn = _verses.Count;
        }


        // Error handling for when the random index is at the end of the list
        if (_randomVerse + _versesToLearn > _verses.Count)
        {
            // If we're at the end, select the last `_versesToLearn` verses
            _randomVerse = _verses.Count - _versesToLearn;
        }

        // Add the selected verses to the list
        for (int i = 0; i < _versesToLearn; i++)
        {
            verseReference.Add(_verses[_randomVerse + i]);
            
            // used for testing input
            // Console.WriteLine(verseReference[i]);
        }


        return verseReference;
    
    }

}
