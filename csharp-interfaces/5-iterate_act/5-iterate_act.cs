using System;
using System.Collections.Generic;

// Base class providing foundational properties for inheritance
abstract class Base
{
    private string _name = string.Empty; // Backing field for name

    // Property to get or set the name associated with the instance
    public string name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    // Overrides the default ToString() method to display custom properties
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

// Interfaces
public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

// Door class implementing IInteractive
class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

// Decoration class implementing IInteractive and IBreakable
class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;

        if (durability <= 0)
            throw new ArgumentException("Durability must be greater than 0");
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        if (durability > 0)
        {
            durability--;
            if (durability > 0)
                Console.WriteLine($"You hit the {name}. It cracks.");
            else
                Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

// Key class implementing ICollectable
class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

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

// RoomObjects class with IterateAction method
class RoomObjects
{
    // Iterates through a list of room objects and executes methods based on their implemented interfaces
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            // Check if the object implements IInteractive
            if (type == typeof(IInteractive) && obj is IInteractive interactive)
            {
                interactive.Interact();
            }
            // Check if the object implements IBreakable
            else if (type == typeof(IBreakable) && obj is IBreakable breakable)
            {
                breakable.Break();
            }
            // Check if the object implements ICollectable
            else if (type == typeof(ICollectable) && obj is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Bathroom Door");
        Decoration cabinet = new Decoration("Bathroom Cabinet", 1, true);
        Decoration mirror = new Decoration("Mirror");
        Decoration window = new Decoration("Window");

        List<Base> allObjects = new List<Base>
        {
            frontDoor,
            cabinet,
            mirror,
            window
        };

        // Execute actions based on interfaces
        RoomObjects.IterateAction(allObjects, typeof(IInteractive));
        RoomObjects.IterateAction(allObjects, typeof(IBreakable));
        RoomObjects.IterateAction(allObjects, typeof(ICollectable));
    }
}
