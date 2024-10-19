using System;

public class Queue<T>
{
    public Queue()
    {
    }

    // Method to return the type of the queue
    public Type CheckType()
    {
        return typeof(T);
    }
}