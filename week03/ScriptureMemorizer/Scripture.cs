using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(w => new Word(w))
                     .ToList();
    }

    public void HideRandomWords(int count)
    {
        if (count <= 0)
            return;

        List<Word>  visibleWords = GetVisibleWords();

        if (visibleWords.Count == 0)
            return;

        HideRandomWordsInternal(visibleWords, count);
    }

    private List<Word> GetVisibleWords()
    {
        return _words.Where(w => !w.IsHidden()).ToList();
    }

    private void HideRandomWordsInternal(List<Word> visibleWords, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count == 0)
                break;

            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {text}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}