using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }

        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
        }

        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("Array Length: " + newArray.Length);
        return newArray;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = Array.CreatePrint(5);
    }
}
