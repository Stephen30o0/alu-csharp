#nullable enable

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
/// Player's CalculateHealth delegate.
/// </summary>
/// <param name="amount">Amount for health.</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Calculate Modifier delegate.
/// </summary>
/// <param name="baseValue">Base value.</param>
/// <param name="modifier">Modifier: Weak, Base, Strong.</param>
/// <returns>Returns a modified value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Player class.
/// </summary>
public class Player
{
    /// <summary>
    /// Event handler for CurrentHPArgs.
    /// </summary>
    public event EventHandler<CurrentHPArgs>? HPCheck;

    // Player's name
    private string name { get; set; }
    // Player's max hp.
    private float maxHp { get; set; }
    // Player's hp.
    private float hp { get; set; }
    // Player's status.
    private string status { get; set; }

    /// <summary>
    /// Player constructor.
    /// </summary>
    /// <param name="name">Player's name.</param>
    /// <param name="maxHp">Player's max hp.</param>
    /// <param name="status">Player's status.</param>
    public Player(string name = "Player", float maxHp = 100f, string status = "Undefined")
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.status = status == "Undefined" ? $"{name} is ready to go!" : status;
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Prints the name and current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Player takes damage.
    /// </summary>
    /// <param name="damage">Amount of damage taken.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Player heals.
    /// </summary>
    /// <param name="heal">Amount of heals received.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates and sets the new player's hp.
    /// </summary>
    /// <param name="newHp">New hp value.</param>
    public void ValidateHP(float newHp)
    {
        hp = newHp < 0 ? 0 : (newHp > maxHp ? maxHp : newHp);
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies a modifier to the base value.
    /// </summary>
    /// <param name="baseValue">Base value to apply.</param>
    /// <param name="modifier">Modifier: Weak, Base, Strong.</param>
    /// <returns>Modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        return modifier switch
        {
            Modifier.Weak => baseValue * 0.5f,
            Modifier.Base => baseValue * 1f,
            Modifier.Strong => baseValue * 1.5f,
            _ => baseValue,
        };
    }

    // Event used to perform specific status depending on player health
    private void CheckStatus(object? sender, CurrentHPArgs e)
    {
        status = e.currentHp switch
        {
            float n when n == maxHp => $"{name} is in perfect health!",
            float n when n >= maxHp * 0.5f => $"{name} is doing well!",
            float n when n >= maxHp * 0.25f => $"{name} isn't doing too great...",
            float n when n > 0 => $"{name} needs help!",
            _ => $"{name} is knocked out!"
        };
        Console.WriteLine(status);
    }

    // Event used to warn user about their health
    private void HPValueWarning(object? sender, CurrentHPArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(e.currentHp == 0 ? "Health has reached zero!" : "Health is low!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Checks status and performs events depending on the situation.
    /// </summary>
    /// <param name="e">CurrentHPArgs event.</param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        HPCheck?.Invoke(this, e);
        if (e.currentHp <= maxHp * 0.25f)
        {
            HPValueWarning(this, e);
        }
    }
}

/// <summary>
/// Current HP Args.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Current HP cannot be modified.
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// Takes a float newHp and sets it as currentHp's value.
    /// </summary>
    /// <param name="newHp">New currentHp's value.</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}