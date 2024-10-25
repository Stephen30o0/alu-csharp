using System;

/// <summary>
/// Represents a player with health attributes.
/// </summary>
public class Player
{
    // Delegate definition
    public delegate void CalculateHealth(float amount);

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

    /// <summary>
    /// Method to take damage.
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
            Console.WriteLine($"{name} takes {damage} damage!");
            return;
        }

        hp -= damage;
        if (hp < 0) hp = 0; // Ensure hp doesn't go below 0
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary>
    /// Method to heal damage.
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
            Console.WriteLine($"{name} heals {heal} HP!");
            return;
        }

        hp += heal;
        if (hp > maxHp) hp = maxHp; // Ensure hp doesn't exceed maxHp
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
