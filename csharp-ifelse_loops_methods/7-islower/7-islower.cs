using System;

class Character
{
    public static bool IsLower(char c)
    {
        return c >= 'a' && c <= 'z';
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of characters:");

        string input = Console.ReadLine();

        foreach (char c in input)
        {
            Console.WriteLine($"{c} is {(IsLower(c) ? "lowercase" : "uppercase")}");
        }
    }
}
