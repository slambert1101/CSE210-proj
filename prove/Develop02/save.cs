//this class will save the journal entries.
using System.IO;

public class SaveFile()
{

    public static string _fileName;
    public List<string> _fileList;
    

    public void Ask()
    {
        Console.WriteLine("What is the File name? ");
        _fileName = Console.ReadLine();
        
    }

    public void Save()
    {

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            
            foreach (string s in _fileList)
            {
            outputFile.WriteLine(s);
            
            }
        }

    }

    public static List<string> LoadFile()
    {
        

        List<string> entries = new List<string>();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            entries.Add(line);
        }

        return entries;


    }

}