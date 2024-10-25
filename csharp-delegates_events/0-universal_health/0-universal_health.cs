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
}
