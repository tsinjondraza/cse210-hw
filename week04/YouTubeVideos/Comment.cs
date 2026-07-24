public class Comment
{
    private string _author;
    private string _text;
    public Comment(string author, string comment)
    {
        _author = author;
        _text = comment;
    }

    public string DisplayCommentText()
    {
        return $"{_author}: {_text}";
    }

}