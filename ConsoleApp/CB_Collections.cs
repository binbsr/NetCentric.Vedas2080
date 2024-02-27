using System.Collections.Generic;

class Collections
{
    void LearnCollections()
    {
        // Arrays
        double[] weights = [34.5, 67.8, 89.6];
        string[,] nameList = new string[3, 4];
        string[][] names = [["A", "B", "C"],["D", "E"],["F", "G", "H"]];        

        // Builtin Collections: List, Dictionary etc.
        List<string> strudentNames = ["Ram", "Shyam"];

        Dictionary<string, char> studentGrades = new()
        {
            ["Ram"] = 'A', 
            ["Ram1"] = 'C', 
        };

        var grade = studentGrades["Ram"];        
    }
}