using System;
using System.Collections.Generic;

class Dictionary
{
    public static void CreatePrint()
    {
        Dictionary<string, int> nameAgeDict = new Dictionary<string, int>();
        nameAgeDict.Add("Alice", 25);
        nameAgeDict.Add("Bob", 30);
        nameAgeDict.Add("Charlie", 22);

        foreach (var pair in nameAgeDict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} years old");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary.CreatePrint();
    }
}
