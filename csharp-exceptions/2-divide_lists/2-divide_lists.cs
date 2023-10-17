using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        
        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int a = (i < list1.Count) ? list1[i] : 1;
                int b = (i < list2.Count) ? list2[i] : 1;

                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                else
                {
                    result.Add(a / b);
                }
            }
        }
        catch
        {
            Console.WriteLine("Out of range");
        }
        
        return result;
    }
}
