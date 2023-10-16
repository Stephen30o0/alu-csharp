using System;
using System.Collections.Generic;

class List
{
    public static List<int> GenerateEvenNumbers(int n)
    {
        List<int> result = new List<int>();

        for (int i = 2; i <= n; i += 2)
        {
            result.Add(i);
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> evenNumbers = List.GenerateEvenNumbers(20);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
    }
}
