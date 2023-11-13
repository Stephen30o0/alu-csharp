﻿using System.Reflection;

/// <summary>
/// Provides utility methods for inspecting object properties and methods.
/// </summary>
class Obj
{
    /// <summary>
    /// Prints the properties and methods of the specified object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        Console.WriteLine($"{t.Name} Properties:");

        foreach (PropertyInfo n in pList)
        {
            Console.WriteLine(n.Name);
        }

        IEnumerable<MethodInfo> nMethod = t.GetMethods();
        Console.WriteLine($"{t.Name} Methods:");

        foreach (MethodInfo m in nMethod)
        {
            if (m.DeclaringType == myObj.GetType())
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}