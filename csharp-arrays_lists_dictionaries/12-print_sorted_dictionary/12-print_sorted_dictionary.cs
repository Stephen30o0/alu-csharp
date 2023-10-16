using System;
using System.Collections.Generic;

class List
{
    public static List<int> RemoveDuplicates(List<int> myList)
    {
        HashSet<int> uniqueElements = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int num in myList)
        {
            if (!uniqueElements.Contains(num))
            {
                uniqueElements.Add(num);
                result.Add(num);
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 1, 2, 3, 2, 4, 5, 3, 6, 7, 6, 8, 9 };
        List<int> result = List.RemoveDuplicates(myList);

        Console.WriteLine("Original List: " + string.Join(", ", myList));
        Console.WriteLine("List with Duplicates Removed: " + string.Join(", ", result));
    }
}
