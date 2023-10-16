using System;
using System.Collections.Generic;

class List
{
    public static void Reverse(List<int> myList)
    {
        myList.Reverse();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> myList2 = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };

        List.Reverse(myList1);
        List.Reverse(myList2);

        Console.WriteLine("Reversed List 1: " + string.Join(", ", myList1));
        Console.WriteLine("Reversed List 2: " + string.Join(", ", myList2));
    }
}
