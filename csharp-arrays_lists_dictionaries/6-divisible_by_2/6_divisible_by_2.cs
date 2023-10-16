using System;
using System.Collections.Generic;

class List
{
    public static List<int> OnlyBy2(List<int> myList)
    {
        List<int> result = new List<int>();

        foreach (int num in myList)
        {
            if (num % 2 == 0)
                result.Add(num);
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> result = List.OnlyBy2(myList);

        Console.WriteLine("Original List: " + string.Join(", ", myList));
        Console.WriteLine("Filtered List: " + string.Join(", ", result));
    }
}
