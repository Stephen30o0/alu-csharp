using System;
using System.Collections.Generic;

class List
{
    public static bool HasDuplicates(List<int> myList)
    {
        HashSet<int> uniqueElements = new HashSet<int>();

        foreach (int num in myList)
        {
            if (uniqueElements.Contains(num))
                return true;
            uniqueElements.Add(num);
        }

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() { 1, 2, 3, 4, 5, 3 };
        List<int> myList2 = new List<int>() { 10, 20, 30, 40, 50 };

        bool hasDuplicates1 = List.HasDuplicates(myList1);
        bool hasDuplicates2 = List.HasDuplicates(myList2);

        Console.WriteLine("List 1 has duplicates: " + hasDuplicates1);
        Console.WriteLine("List 2 has duplicates: " + hasDuplicates2);
    }
}
