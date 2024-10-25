using System;

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

// Define the ICollectable interface with isCollected property and Collect method
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

// Key class that inherits from Base and ICollectable
class Key : Base, ICollectable
{
    // Property to hold if the key has been collected
    public bool isCollected { get; set; }

    // Constructor that sets name and isCollected with default values
    public Key(string name = "Key", bool isCollected = false)
    {
        // Set the name of the key
        this.name = name;
        // Set the collection status of the key
        this.isCollected = isCollected;
    }

    // Implementation of Collect() method as required by ICollectable
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
