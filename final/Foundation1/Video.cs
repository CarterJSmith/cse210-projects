class Video
{
    // Attributes
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    // Behaviors
    public void Display()
    {
        Console.Write($"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds\n\nComments: ");
        Console.WriteLine(GetNumComments());
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine("--------------------");
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }
}