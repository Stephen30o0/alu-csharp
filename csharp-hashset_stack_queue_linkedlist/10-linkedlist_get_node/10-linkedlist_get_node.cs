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

    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        return myLList.AddFirst(n);
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

    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.First != null)
        {
            int value = myLList.First.Value;
            myLList.RemoveFirst();
            return value;
        }

        return 0; // List is empty
    }

    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList != null)
        {
            int index = 0;
            foreach (int item in myLList)
            {
                if (index == n)
                {
                    return item;
                }
                index++;
            }
        }

        return 0; 
}
