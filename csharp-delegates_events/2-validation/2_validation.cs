#nullable enable

using System;

/// <summary>
/// Represents a player character with health properties and methods.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Initializes a new instance of the Player class with specified name and health points.
    /// </summary>
    /// <param name="name">The name of the player (default is "Player").</param>
    /// <param name="maxHp">The maximum health points of the player (default is 100).</param>
    public Player(string? name = "Player", float maxHp = 100f)
    {
        // Check if maxHp is less than or equal to 0
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        // Handle null or empty string for name
        this.name = !string.IsNullOrEmpty(name) ? name : "";

        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints the current health status of the player.
    /// </summary>
    public void PrintHealth()
    {
        // Always show the name, including the default "Player"
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Takes damage and updates health accordingly.
    /// </summary>
    /// <param name="damage">The amount of damage taken.</param>
    public void TakeDamage(float damage)
    {
        float newHp = hp - damage; // Calculate new HP
        Console.WriteLine($"{name} takes {damage} damage!");

        // Validate and update HP
        ValidateHP(newHp);
    }

    /// <summary>
    /// Heals health and updates health accordingly.
    /// </summary>
    /// <param name="heal">The amount of health restored.</param>
    public void HealDamage(float heal)
    {
        float newHp = hp + heal; // Calculate new HP
        Console.WriteLine($"{name} heals {heal} HP!");

        // Validate and update HP
        ValidateHP(newHp);
    }

    /// <summary>
    /// Validates and sets the player's health points.
    /// </summary>
    /// <param name="newHp">The new health value to validate.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }
}
