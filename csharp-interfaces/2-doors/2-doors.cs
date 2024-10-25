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

// Define the IInteractive interface with an Interact method
interface IInteractive
{
    void Interact();
}

// Door class that inherits from Base and implements IInteractive
class Door : Base, IInteractive
{
    // Constructor that sets the name with a default value of "Door"
    public Door(string name = "Door")
    {
        this.name = name;
    }

    // Implementation of Interact() method as required by IInteractive
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
