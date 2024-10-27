public class Word
{
    // attributes
    private string _scriptureWord;

    // constructors
    public Word(string scriptureWord)
    {
        // removes punctuation but leaves "_"
        _scriptureWord = new string(scriptureWord.Where(c => !char.IsPunctuation(c) || c == '_').ToArray());

    }

    // behaviors
    public Word ReplaceWord()
    {
        Word test = new Word(new string('_', _scriptureWord.Length));
        return test;
    }    

    public void DisplayWord()
    {
        Console.Write(_scriptureWord+" "); 
    }
}