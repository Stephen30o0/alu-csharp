using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myList = new LinkedList<int>();

        if (size < 0)
        {
            return myList; 
        }

        for (int i = 0; i < size; i++)
        {
            myList.AddLast(i);
            Console.WriteLine(i);
        }

        return myList;
    }

    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;

        if (myLList != null)
        {
            foreach (int item in myLList)
            {
                count++;
            }
        }

        return count;
    }

    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;

        if (myLList != null)
        {
            foreach (int item in myLList)
            {
                if (item == value)
                {
                    return index;
                }
                index++;
            }
        }

        return -1; 
    }
}
