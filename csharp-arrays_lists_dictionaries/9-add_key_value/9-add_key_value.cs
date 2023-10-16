using System;
using System.Collections.Generic;

class List
{
    public static List<int> Concatenate(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();
        result.AddRange(list1);
        result.AddRange(list2);
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() { 1, 2, 3 };
        List<int> list2 = new List<int>() { 4, 5, 6, 7 };

        List<int> concatenatedList = List.Concatenate(list1, list2);

        Console.WriteLine("List 1: " + string.Join(", ", list1));
        Console.WriteLine("List 2: " + string.Join(", ", list2));
        Console.WriteLine("Concatenated List: " + string.Join(", ", concatenatedList));
    }
}
