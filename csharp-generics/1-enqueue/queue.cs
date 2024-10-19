using System;

/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// A node in the queue.
    /// </summary>
    public class Node
    {
        public T value; // Can be of any type
        public Node next; // Next node in the queue

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value for the node.</param>
        public Node(T value)
        {
            this.value = value; // Set the value
            this.next = null; // Initialize next to null
        }
    }

    private Node head; // The first node in the queue
    private Node tail; // The last node in the queue
    private int count; // The number of nodes in the queue

    /// <summary>
    /// Initializes a new instance of the <see cref="Queue{T}"/> class.
    /// </summary>
    public Queue()
    {
        head = null; // Initialize head to null
        tail = null; // Initialize tail to null
        count = 0; // Initialize count to 0
    }

    /// <summary>
    /// Adds a new value to the end of the queue.
    /// </summary>
    /// <param name="value">The value to add.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value); // Create a new node

        if (head == null) // If the queue is empty
        {
            head = newNode; // Set head to the new node
            tail = newNode; // Set tail to the new node
        }
        else
        {
            tail.next = newNode; // Link the old tail to the new node
            tail = newNode; // Update the tail to the new node
        }

        count++; // Increment the count of nodes
    }

    /// <summary>
    /// Gets the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes in the queue.</returns>
    public int Count()
    {
        return count; // Return the count of nodes
    }

    /// <summary>
    /// Checks the type of the queue's elements.
    /// </summary>
    /// <returns>The type of the elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T); // Return the type of T
    }
}
