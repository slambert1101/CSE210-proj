using System;

class Word
{
    private string _word;
    private bool _hidden;
    private string _underscore;


    public Word(string word)
    {
        this._word = word;
        this._hidden = false;
        this._underscore = "";
        
        int i = _word.Length;
        while(i > 0)
        {
            this._underscore+="_";
            i-=1;
        }


    }

    public string GetWord()
    {
        if(_hidden != true)
        {
            return _word;
        }
        else
        {
            return _underscore;
        }
        
    }

    public void Hide()
    {
        // int i = _word.Length;
        // while(i > 0)
        // {
        //     _underscore+="_";
        //     i-=1;
        // }
        
        _hidden = true;
    }

    public bool GetBool()
    {
        return _hidden;
    }

}