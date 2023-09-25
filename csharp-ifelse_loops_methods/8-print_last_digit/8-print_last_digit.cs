using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        number = Math.Abs(number);

        int lastDigit = number % 10;

        Console.WriteLine($"Last digit of {number} is {lastDigit}");

        return lastDigit;
    }

    public static void Main(string[] args)
    {
        int num = 12345;
        int lastDigit = PrintLastDigit(num);
    }
}
