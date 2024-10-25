#nullable enable

using System;
using System.Collections.Generic;

/// <summary>
/// Base class providing foundational properties for inheritance.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name associated with the instance. Nullable to allow for optional assignment.
    /// </summary>
    public string? name { get; set; }

    /// <summary>
    /// Overrides the default ToString() method to display custom properties.
    /// </summary>
    /// <returns>A string representation of the object, including its name and type.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Interface defining interactive behavior.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Method to define interaction behavior.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface defining breakable behavior.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Method to define break behavior.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface defining collectable behavior.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets the collection status of the object.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Method to define collect behavior.
    /// </summary>
    void Collect();
}

/// <summary>
/// Class representing a door object that implements interactive behavior.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class with a default or specified name.
    /// </summary>
    /// <param name="Name">The name of the door. Default is "Door".</param>
    public Door(string Name = "Door")
    {
        this.name = Name;
    }

    /// <summary>
    /// Method to define interaction behavior for the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Class representing a decoration object that implements interactive and breakable behaviors.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the decoration.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Indicates whether the decoration is a quest item.
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class with a specified name, durability, and quest item status.
    /// </summary>
    /// <param name="name">The name of the decoration. Default is "Decoration".</param>
    /// <param name="durability">The durability of the decoration. Must be greater than 0.</param>
    /// <param name="isQuestItem">Indicates whether the decoration is a quest item. Default is false.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Method to define interaction behavior for the decoration.
    /// </summary>
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

    /// <summary>
    /// Method to define break behavior for the decoration.
    /// </summary>
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// Class representing a key object that implements collectable behavior.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets the collection status of the key.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Key"/> class with a specified name and collection status.
    /// </summary>
    /// <param name="name">The name of the key. Default is "Key".</param>
    /// <param name="isCollected">Indicates whether the key is collected. Default is false.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Method to define collect behavior for the key.
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            Console.WriteLine($"You pick up the {name}.");
            isCollected = true;
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

/// <summary>
/// Generic collection class for managing room objects.
/// </summary>
/// <typeparam name="T">The type of objects the collection will hold.</typeparam>
public class Objs<T> : List<T>
{
}