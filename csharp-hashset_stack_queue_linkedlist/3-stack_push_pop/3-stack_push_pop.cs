﻿using System.Collections;

class MyStack{

        static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search){
        Console.WriteLine($"Number of items: {aStack.Count}");

        if(aStack.Count == 0){
            Console.WriteLine("Stack is empty");
        }else{
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        if(aStack.Contains(search)){
            Console.WriteLine($"Stack contains \"{search}\" : True");
        }else{
            Console.WriteLine($"Stack contains \"{search}\" : False");
        }

        for(int i = 0; i <= aStack.Count; i++){
            if(aStack.Contains(search)){
                string temp = aStack.Pop();
            }
        }

        aStack.Push(newItem);

        return aStack;
    }