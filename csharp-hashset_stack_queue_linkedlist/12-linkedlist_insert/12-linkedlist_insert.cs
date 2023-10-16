using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = myLList.First;
        while (newNode != null && newNode.Value < n)
        {
            newNode = newNode.Next;
        }
        if (newNode == null)
        {
            newNode = myLList.AddLast(n);
        }
        else
        {
            newNode = myLList.AddBefore(newNode, n);
        }
        return newNode;
    }
}
