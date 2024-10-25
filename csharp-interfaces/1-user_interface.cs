using System;

#nullable enable

// Base class providing foundational properties for inheritance.
abstract class Base
{
    private string _name = string.Empty;

    // Property for the name of the instance
    public string name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    // Overrides ToString() to display the name and type
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

// Define the IInteractive interface with an Interact method
interface IInteractive
{
    void Interact();
}

// Define the IBreakable interface with durability property and Break method
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

// Define the ICollectable interface with isCollected property and Collect method
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

// TestObject class inherits from Base and implements IInteractive, IBreakable, and ICollectable
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    // Properties for durability and isCollected
    public int durability { get; set; }
    public bool isCollected { get; set; }

    // Methods for each interface
    public void Interact()
    {
        Console.WriteLine("Interacting with the object.");
    }

    public void Break()
    {
        Console.WriteLine("Object is breaking.");
    }

    public void Collect()
    {
        Console.WriteLine("Object collected.");
    }
}
