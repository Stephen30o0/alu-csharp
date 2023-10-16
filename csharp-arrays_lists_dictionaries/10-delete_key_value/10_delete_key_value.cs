using System;
using System.Collections.Generic;

class List
{
    public static int FindIndex(List<int> myList, int target)
    {
        int index = myList.IndexOf(target);
        return index;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };
        int target1 = 40;
        int target2 = 99;

        int index1 = List.FindIndex(myList, target1);
        int index2 = List.FindIndex(myList, target2);

        Console.WriteLine("Index of {0}: {1}", target1, index1);
        Console.WriteLine("Index of {0}: {1}", target2, index2);
    }
}
