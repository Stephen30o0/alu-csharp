using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
        }
        return linkedList;
    }
}
