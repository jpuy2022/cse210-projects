public class Comment{
    private string _name;
    private string _text;

    public void setName(string n)
    {
        _name = n;
    }
    public void setText(string t)
    {
        _text = t;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"- {_name}: {_text}");
    }
}