using System;
using System.Collections.Generic;

class Dictionary
{
    public static int LookupAge(Dictionary<string, int> nameAgeDict, string name)
    {
        if (nameAgeDict.ContainsKey(name))
        {
            return nameAgeDict[name];
        }
        else
        {
            Console.WriteLine($"Name '{name}' not found in the dictionary.");
            return -1;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> nameAgeDict = new Dictionary<string, int>();
        nameAgeDict.Add("Alice", 25);
        nameAgeDict.Add("Bob", 30);
        nameAgeDict.Add("Charlie", 22);

        string name1 = "Alice";
        string name2 = "Eve";

        int age1 = Dictionary.LookupAge(nameAgeDict, name1);
        int age2 = Dictionary.LookupAge(nameAgeDict, name2);

        Console.WriteLine($"{name1}'s age: {age1} years");
        Console.WriteLine($"{name2}'s age: {age2} years");
    }
}
