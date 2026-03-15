using System;
public class Prompts
{
    public List<string> _promptList = new List<string>
    {
        "Do I pray today?",
        "Do I read the scriptures today?",
        "What possitive things happened today?",
        "How I showed my love to others today?",
        "I did all my labor today?",
        "What I need to do tomorrow?",
        "How I showed my love for my wife today?",
        "What I did for my calling at church?"
    };

    public string GetAPrompt()
    {
        Random random = new Random();
        int i = random.Next(_promptList.Count);
        return _promptList[i];
    }
}