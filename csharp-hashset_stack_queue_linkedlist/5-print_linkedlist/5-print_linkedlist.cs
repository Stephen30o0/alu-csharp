﻿using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myList = new LinkedList<int>();

        if (size < 0)
        {
            return myList; // Return an empty list for negative size
        }

        for (int i = 0; i < size; i++)
        {
            myList.AddLast(i);
            Console.WriteLine(i);
        }

        return myList;
    }
}
