using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        LinkedListNode<int> current = myLList.First;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}
