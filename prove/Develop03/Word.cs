using System;

class Word
{
    private string _word;
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public string _scripture;
    public void SetScript(string _justScript)
    {
        _scripture = _justScript;
    }
    public string[] SplitWords(string _justScript)
    {
        string[] _words = _justScript.Split(" ");
        return _words;
    }
    public string HideWord()
    {
        if (_hidden == true)
        {
            return "____";
        }
        else
            {
                return _word;
            }
    }
    
}