using System;
using System.Text;

class Program
{
    static void Main()
    {

    }
}

/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T value { get; set; } = default(T);

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node next { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// The first node in the queue.
    /// </summary>
    public Node head { get; set; }

    /// <summary>
    /// The last node in the queue.
    /// </summary>
    public Node tail { get; set; }

    /// <summary>
    /// The number of items in the queue.
    /// </summary>
    public int count;

    /// <summary>
    /// Returns the type of elements in the queue as a string.
    /// </summary>
    /// <returns>A string representation of the type of elements.</returns>
    public String CheckType()
    {
        return (typeof(T).ToString());
    }

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to add to the queue.</param>
    public void Enqueue(T value)
    {
        Node n = new Node(value);
        if (count == 0)
        {
            head = n;
            tail = n;
        }
        else
        {
            tail.next = n;
            tail = n;
        }
        this.count += 1;
    }

    /// <summary>
    /// Removes and returns the first element from the queue.
    /// </summary>
    /// <returns>The value of the removed element.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        T val = head.value;
        head = head.next;
        count -= 1;
        return (val);
    }

    /// <summary>
    /// Returns the first element without removing it from the queue.
    /// </summary>
    /// <returns>The value of the first element in the queue.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>
    /// Displays all elements in the queue.
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        while (head != null)
        {
            Console.WriteLine(head.value);
            head = head.next;
        }
    }

    /// <summary>
    /// Concatenates all elements in the queue into a single string.
    /// </summary>
    /// <returns>A concatenated string of all elements in the queue.</returns>
    public String Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty ");
            return (null);
        }
        if (typeof(T) == typeof(String) || typeof(T) == typeof(Char))
        {
            var concatString = new StringBuilder("");
            while (head != null)
            {
                concatString.Append(head.value);
                if (typeof(T) == typeof(String))
                {
                    concatString.Append(" ");
                }
                head = head.next;
            }
            return (concatString.ToString());
        }
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return (null);
    }

    /// <summary>
    /// Returns the number of items in the queue.
    /// </summary>
    /// <returns>The number of items in the queue.</returns>
    public int Count()
    {
        return (this.count);
    }
}