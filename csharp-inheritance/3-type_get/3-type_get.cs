using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        Type objectType = myObj.GetType();

        Console.WriteLine($"Properties and Methods of {objectType.Name}:");

        // Print Properties
        Console.WriteLine("Properties:");
        foreach (var property in objectType.GetProperties())
        {
            Console.WriteLine($"- {property.Name}");
        }

        // Print Methods
        Console.WriteLine("\nMethods:");
        foreach (var method in objectType.GetMethods())
        {
            Console.WriteLine($"- {method.Name}");
        }
    }
}
