using System;
using System.Diagnostics;

class Scripture
{
    private List<Word> _text = [];

    private string _fullVerse;
    private Reference _reference;

    private bool _allHidden;
    public Scripture(Reference reference, string contentOfVerse)
    {
        this._reference = reference;
        //change contentOfVerse into list of Words
        this._fullVerse = contentOfVerse;
        _allHidden = false;
        List<string> stringList = contentOfVerse.Split(" ").ToList();

        
        foreach(string i in stringList)
        {
            Word word = new Word(i);
            
            
            _text.Add(word);
            
        }
        
       

    }

   


    public string GetFullVerse()
    {
        return _fullVerse;
    }
    public string DisplayVerse()
    {
        List<string> strings = new List<string>();
        foreach(Word word in _text)
        {
            strings.Add(word.GetWord());
        }
        string combined = string.Join(" ", strings.ToArray());
        return _reference.GetReference() + " " + combined;
    }

    public void HideRandomWords()
    {
        var random = new Random();
        int index = random.Next(_text.Count);
        
        int wordCount = 0;
        foreach(Word word in _text)
        {
            if(word.GetBool() == false)
            {
                wordCount+=1;
            }
        }

        if(wordCount > 3)
        {

        
            int n = 0;
            while(n < 3)
            {

                if(_text[index].GetBool() == false)
                {
                    _text[index].Hide();
                    n+=1;
                }
                index = random.Next(_text.Count);

            }
        }
        else
        {
            foreach(Word word in _text)
            {
                word.Hide();
                _allHidden = true;
            }
        }

    }

    public bool GetAllHidden()
    {
        return _allHidden;
    }



}