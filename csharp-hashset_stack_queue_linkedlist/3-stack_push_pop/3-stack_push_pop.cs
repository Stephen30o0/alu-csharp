﻿using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains {search}: {containsSearch}");

        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();
            bool foundSearch = false;

            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (!foundSearch)
                {
                    if (item == search)
                    {
                        foundSearch = true;
                    }
                }
                else
                {
                    tempStack.Push(item);
                }
            }

            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        aStack.Push(newItem);

        return aStack;
    }
}
