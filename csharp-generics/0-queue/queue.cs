using System;
/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Queue{T}"/> class.
    /// </summary>
    public Queue()
    {
        // Constructor code
    }

    /// <summary>
    /// Checks the type of the queue's elements.
    /// </summary>
    /// <returns>The type of the elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}