using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        LinkedListNode<int> currentNode = myLList.First;
        int index = 0;
        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return index;
            }
            currentNode = currentNode.Next;
            index++;
        }
        return -1;
    }
}
