using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;


    public Reference(string book, string chapter, string verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public string GetReference()
    {
        string fullReference = $"{_book} {_chapter}:{_verse}";
        return fullReference;
    }


}