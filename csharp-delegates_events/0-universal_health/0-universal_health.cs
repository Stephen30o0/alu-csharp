#nullable enable
using System;

/// <summary>
/// Represents a player with health attributes.
/// </summary>
public class Player
{
    // Private properties
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Initializes a new instance of the Player class.
    /// </summary>
    /// <param name="name">The name of the player (default is "Player").</param>
    /// <param name="maxHp">The maximum health points of the player (default is 100).</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        // Use the provided name or default to "Player"
        this.name = string.IsNullOrWhiteSpace(name) ? "Player" : name;

        // Validate maxHp
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        // Set hp to the same value as maxHp
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Prints the current health status of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
