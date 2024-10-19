using System;

/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        public T value; // Value of the node
        public Node next; // Reference to the next node

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value for the new node.</param>
        public Node(T value)
        {
            this.value = value; // Set the value of the node
            this.next = null; // Set the next node to null
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
        count = 0; // Initialize count to zero
    }

    /// <summary>
    /// Adds a new value to the end of the queue.
    /// </summary>
    /// <param name="value">The value to add to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value); // Create a new node
        if (head == null) // If the queue is empty
        {
            head = newNode; // Make the new node the head
        }
        else
        {
            tail.next = newNode; // Link the new node to the end of the queue
        }
        tail = newNode; // Update the tail to the new node
        count++; // Increment the count
    }

    /// <summary>
    /// Removes the first value from the queue and returns it.
    /// </summary>
    /// <returns>The value of the first node or default value if the queue is empty.</returns>
    public T Dequeue()
    {
        if (head == null) // If the queue is empty
        {
            Console.WriteLine("Queue is empty");
            return default!; // Return the default value of type T
        }

        T value = head.value!; // Get the value of the head node
        head = head.next; // Move head to the next node
        count--; // Decrement the count

        if (head == null) // If the queue is now empty
        {
            tail = null; // Set tail to null
        }

        return value; // Return the value of the dequeued node
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>The count of nodes in the queue.</returns>
    public int Count()
    {
        return count; // Return the current count
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
