using System;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = new int[] { 0, 1, 2, 3, 4 };

        foreach (int num in myArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Array Length: " + myArray.Length);
    }
}
