class Comment
{
    // attributes
    private string _commenterName;
    private string _commentText;

    // behaviors
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_commentText} \n");
    }
}