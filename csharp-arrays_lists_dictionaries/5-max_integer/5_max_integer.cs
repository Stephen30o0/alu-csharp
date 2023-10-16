using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int max = myList[0];
        foreach (int num in myList)
        {
            if (num > max)
                max = num;
        }

        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() { 98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8 };
        List<int> myList2 = new List<int>() { 98, 972, 971, -32, 972, 972, -727 };

        Console.WriteLine("Max: " + List.MaxInteger(myList1));
        Console.WriteLine("Max: " + List.MaxInteger(myList2));
    }
}
