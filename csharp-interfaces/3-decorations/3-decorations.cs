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

// Define the IBreakable interface with durability property and Break method
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

// Decoration class that inherits from Base, IInteractive, and IBreakable
class Decoration : Base, IInteractive, IBreakable
{
    // Public boolean to indicate if the decoration is a quest item
    public bool isQuestItem { get; set; }

    // Public property to hold the durability value
    public int durability { get; set; }

    // Constructor that sets name, durability, and isQuestItem with default values
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        // Set the name of the decoration
        this.name = name;

        // Check durability value; throw exception if 0 or less
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
        this.durability = durability;

        // Set if the item is a quest item
        this.isQuestItem = isQuestItem;
    }

    // Implementation of Interact() method as required by IInteractive
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    // Implementation of Break() method as required by IBreakable
    public void Break()
    {
        if (durability > 0)
        {
            durability--;
            if (durability > 0)
            {
                Console.WriteLine($"You hit the {name}. It cracks.");
            }
            else
            {
                Console.WriteLine($"You smash the {name}. What a mess.");
            }
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
