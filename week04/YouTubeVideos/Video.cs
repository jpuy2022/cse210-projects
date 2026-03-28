using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public void SetTitle(string t)
    {
        _title = t;
    }
    public void SetAuthor(string a)
    {
        _author = a;
    }

    public void SetLength(int l)
    {
        _length = l;
    }


    public void AddComment(Comment oneComment)
    {
        _comments.Add(oneComment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} || Author: {_author} || Length: {_length} s");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
        Console.WriteLine(new string('-', 30));

    }

}