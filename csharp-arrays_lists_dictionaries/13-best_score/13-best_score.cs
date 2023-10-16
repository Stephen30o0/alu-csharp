using System;
using System.Collections.Generic;

class List
{
    public static List<int> SortList(List<int> myList)
    {
        myList.Sort();
        return myList;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 9, 1, 5, 4, 7, 2, 6, 3, 8 };
        List<int> sortedList = List.SortList(myList);

        Console.WriteLine("Original List: " + string.Join(", ", myList));
        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
    }
}
