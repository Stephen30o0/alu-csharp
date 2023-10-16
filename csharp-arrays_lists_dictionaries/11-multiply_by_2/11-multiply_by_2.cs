﻿using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (var kvp in myDict)
        {
            newDict[kvp.Key] = kvp.Value * 2;
        }

        return newDict;
    }
}
