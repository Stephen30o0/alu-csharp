class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }

        array[index] = n;
        return array;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, 1, 2, 3, 4, 5, 6 };

        PrintArray(array);
        Array.ReplaceElement(array, 1, 98);
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}
