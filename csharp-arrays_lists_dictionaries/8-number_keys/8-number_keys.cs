using System;
using System.Collections.Generic;

public class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;
        foreach (var pair in myDict)
        {
            count++;
        }
        return count;
    }
}
