using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {

        int wordsToHide = 3;

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

            if (visibleWords.Count == 0)
                return;

            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()}\n{text}".Trim();
    }
}