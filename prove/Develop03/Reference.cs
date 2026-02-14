using System;

class Reference
{
    public string _reference = "";
    public string _scripture;
    public string _justScript;
    public string[] _scriptParts;
    public void Set(string _aScript)
    {
        _scripture = _aScript;
    }
    public string[] SplitScript(string _scripture)
    {
        string[] _scriptParts = _scripture.Split("%");
        return  _scriptParts;
    }
    public void DisplayRef()
    {
        _reference = _scriptParts[0];
        Console.WriteLine($"{_reference}");
    }
    public string GetScript()
    {
        _justScript = _scriptParts[1];
        return _justScript;
    }
    //get to send to word
}