﻿using System.Collections.Generic;

class LList{

    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n){
            LinkedListNode<int> current;
            current = myLList.First;
            while(current != null){
                if(current.Value >= n){
                    myLList.AddBefore(current, n);
                    return current.Previous;
                }
              current = current.Next;
            }
            return current;
        }
    }