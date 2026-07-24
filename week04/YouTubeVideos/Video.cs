using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Video
{
    private string _title;
    private int _length;
    private string _author;
    private List<Comment> _comments;

    public Video(string author, string title, int length, List<Comment> comments)
    {
        _author = author;
        _length = length;
        _title = title;
        _comments = comments;
    }
    public string DisplayVideoDetails()
    {
        return $"{_title} by {_author} {_length}";
    }

    public int GiveCommentsNumber()
    {
        return _comments.Count;
    }

    public List<string> DisplayComments()
    {
        List<string> commentList = new List<string>();
        foreach (Comment comment in _comments)
        {
            commentList.Add(comment.DisplayCommentText());
        }
        return commentList;
    }

}