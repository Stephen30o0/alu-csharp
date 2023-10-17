using System;

class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Division operation done.");
        }
    }
}
