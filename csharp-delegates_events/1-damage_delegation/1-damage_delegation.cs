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

    // Define the delegate type
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Initializes a new instance of the Player class with specified name and health points.
    /// </summary>
    /// <param name="name">The name of the player (default is "Player").</param>
    /// <param name="maxHp">The maximum health points of the player (default is 100).</param>
    public Player(string? name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = !string.IsNullOrEmpty(name) ? name : "";
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints the current health status of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Takes damage and updates the player's health.
    /// </summary>
    /// <param name="damage">The amount of damage taken.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
        
        hp -= damage;
        Console.WriteLine($"{name} takes {damage} damage!");
        // Ensure hp does not drop below 0
        if (hp < 0) hp = 0;
    }

    /// <summary>
    /// Heals the player and updates their health.
    /// </summary>
    /// <param name="heal">The amount of health restored.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }

        hp += heal;
        Console.WriteLine($"{name} heals {heal} HP!");
        // Ensure hp does not exceed maxHp
        if (hp > maxHp) hp = maxHp;
    }
}
