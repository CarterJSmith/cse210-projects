public class Verse
{
    // Attributes
    private List<Word> _words = new List<Word>();
    // private List<int> _indexesToMemorize = new List<int>();
    private HashSet<int> _replacedIndexes = new HashSet<int>();

    // Constructor
    public Verse(List<string> verses)
    {
        // Adds the words to the _words list
        for (int verse = 0; verse < verses.Count; verse++)
        {
            string[] verseArray = verses[verse].Split(' ');
            foreach (string word in verseArray)
            {
                Word wordsToAdd = new Word(word);
                _words.Add(wordsToAdd);
            }
        }  
    }

    // Behaviors
    public void DisplayVerses()
    {
        foreach (Word word in _words)
        {  
            word.DisplayWord(); // Assuming DisplayWord() prints the word
        }
    }

    public bool MemorizeVerse()
    {
        Random random = new Random();
        int wordsToHide = 3;

        // Determine how many words we can actually hide
        int availableWords = _words.Count - _replacedIndexes.Count;
        int wordsToReplace = Math.Min(wordsToHide, availableWords);

        // If there are no words left to replace, then we return
        if (wordsToReplace <= 0) return false;

        // help from AI to use a hashset
        HashSet<int> indexesToMemorize = new HashSet<int>();

        // Generate unique random indexes to hide words
        while (indexesToMemorize.Count < wordsToReplace)
        {
            int randomIndex = random.Next(0, _words.Count);

            // Only add the index if it hasn't been replaced yet
            if (!_replacedIndexes.Contains(randomIndex))
            {
                indexesToMemorize.Add(randomIndex);
            }
        }

        // Replace words at the chosen indexes with underscores
        foreach (int index in indexesToMemorize)
        {
            // Replace the word with "_"
            _words[index] = _words[index].ReplaceWord(); 
            // Add the index to the replaced indexes
            _replacedIndexes.Add(index); 
        }

        return true;
    }


}