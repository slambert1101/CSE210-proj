//this class will save the journal entries.
using System.IO;

public class Save
{

    public string _fileName;
    public List<string> _fileList; 

    public void Ask()
    {
        Console.WriteLine("What is the File name? ");
        _fileName = Console.ReadLine();
        //return _fileName;
    }

    public void SaveFile()
    {

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            
            outputFile.WriteLine($"{_fileList}");
    
            
        }

    }


}