using System;

/// <summary>
/// Modifier used with delegates.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak default value should be 0.5.
    /// </summary>
    Weak,
    /// <summary>
    /// Base default value should be 1.
    /// </summary>
    Base,
    /// <summary>
    /// Strong default value should be 1.5.
    /// </summary>
    Strong
}

/// <summary>
/// Delegate for calculating player's health.
/// </summary>
/// <param name="amount">The amount to modify the player's health by.</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Delegate for calculating modifier.
/// </summary>
/// <param name="baseValue">The base value to be modified.</param>
/// <param name="modifier">The modifier to apply (Weak, Base, Strong).</param>
/// <returns>The modified value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Represents a player character with health properties and methods.
/// </summary>
public class Player
{
    // Player's name.
    private string name { get; set; }
    // Player's maximum health points.
    private float maxHp { get; set; }
    // Player's current health points.
    private float hp { get; set; }

    /// <summary>
    /// Initializes a new instance of the Player class.
    /// </summary>
    /// <param name="name">The name of the player (default is "Player").</param>
    /// <param name="maxHp">The maximum health points of the player (default is 100f).</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = !string.IsNullOrEmpty(name) ? name : "Player";

        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }

        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints the name and current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {FormatNumber(hp)} / {FormatNumber(maxHp)} health");
    }

    /// <summary>
    /// Reduces the player's health by the specified damage amount.
    /// </summary>
    /// <param name="damage">The amount of damage taken by the player.</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }

        Console.WriteLine($"{name} takes {FormatNumber(damage)} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Increases the player's health by the specified healing amount.
    /// </summary>
    /// <param name="heal">The amount of health restored to the player.</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }

        Console.WriteLine($"{name} heals {FormatNumber(heal)} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates and sets the player's health to ensure it is within valid bounds.
    /// </summary>
    /// <param name="newHp">The new health value to set.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp >= maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

    /// <summary>
    /// Applies a modifier to a base value.
    /// </summary>
    /// <param name="baseValue">The base value to be modified.</param>
    /// <param name="modifier">The modifier to apply (Weak, Base, Strong).</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float modifiedVal = baseValue;
        switch (modifier)
        {
            case Modifier.Weak:
                modifiedVal = baseValue * 0.5f;
                break;
            case Modifier.Base:
                modifiedVal = baseValue * 1f;
                break;
            case Modifier.Strong:
                modifiedVal = baseValue * 1.5f;
                break;
        }
        return modifiedVal;
    }

    /// <summary>
    /// Formats a number to remove unnecessary decimal places.
    /// </summary>
    /// <param name="number">The number to format.</param>
    /// <returns>The formatted number as a string.</returns>
    private string FormatNumber(float number)
    {
        if (number % 1 == 0)
        {
            return ((int)number).ToString();
        }
        else
        {
            return number.ToString("0.##");
        }
    }
}