using System;

public class FileReader
{
    string _fileName;
    List<string> _lines = new List<string>();

    public FileReader(string fileName)
    {

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _lines.Add(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }

    public List<string> GetLines()
    {
        return _lines;
    }

    public int TotalLines()
    {
        return _lines.Count();
    }

}