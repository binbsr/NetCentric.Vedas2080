using System;
using System.IO;
class FDHandling
{
    public void CreateFile()
    {
        var folderPath = @"D:\Apps\NetCentric.Vedas2080\ConsoleApp\CG_FileIO";
        var filePath = $"{folderPath}\\student.txt";
        File.WriteAllText(filePath, "This is first line");

        // Create 10 text files with names in format FileA1.txt, FileB2.txt ...
        // Each file should contain current datetime as its content   
        for (var counter = 'A'; counter <= 'J'; counter++)
        {
            //Console.WriteLine((int)counter);
            File.WriteAllText($"{folderPath}\\File{counter}{(int)counter - 64}.txt", DateTime.Now.ToLongDateString());
        }
    }

    public void ReadFile()
    {
        var filePath = "D:\\stories.txt";
        var fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);

        // Count number of words and sentences
        var sentences = fileContent.Split(['.', '?', '!']);
        Console.WriteLine($"Number of sentences: {sentences.Length}");
        // foreach (var sentence in sentences)
        // {
        //     Console.WriteLine(sentence);
        // }
        var words = fileContent.Split([" ", "\\n", ":", "-","\\", "."], StringSplitOptions.RemoveEmptyEntries); 
        Console.WriteLine($"Number of words: {words.Length}");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}