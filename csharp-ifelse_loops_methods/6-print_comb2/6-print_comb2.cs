using System;

class Program
{
    static void Main(string[] args)
    {
        for (int firstDigit = 0; firstDigit <= 8; firstDigit++)
        {
            for (int secondDigit = firstDigit + 1; secondDigit <= 9; secondDigit++)
            {
                Console.Write($"{firstDigit:D}{secondDigit:D}{(firstDigit < 8 || secondDigit < 9 ? ", " : "\n")}");
            }
        }
    }
}
