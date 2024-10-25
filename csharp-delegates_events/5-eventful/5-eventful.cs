using System;

// CurrentHPArgs class definition
public class CurrentHPArgs : EventArgs
{
    public float currentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

// Modifier enum definition
public enum Modifier
{
    Weak,
    Base,
    Strong
}

// Player class definition
public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }
    private string status;

    public event EventHandler<CurrentHPArgs>? HPCheck;

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
        this.status = $"{this.name} is ready to go!";

        // Subscribe to the HPCheck event
        HPCheck += CheckStatus;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {FormatNumber(hp)} / {FormatNumber(maxHp)} health");
    }

    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{name} takes {FormatNumber(damage)} damage!");
        }

        // Validate HP regardless of whether damage was taken
        ValidateHP(hp - damage);
    }

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

        // Call OnCheckStatus instead of HPCheck
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    private void CheckStatus(object? sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp >= maxHp / 2)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp >= maxHp / 4)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            status = $"{name} needs help!";
        }
        else
        {
            status = $"{name} is knocked out!";
        }

        Console.WriteLine(status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Change text color to red for zero health
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Change text color to yellow for low health
            Console.WriteLine("Health is low!");
        }
        Console.ResetColor(); // Reset color to default
    }

    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
        {
            HPCheck += HPValueWarning; // Subscribe to HPCheck if health is low
        }
        else
        {
            HPCheck -= HPValueWarning; // Unsubscribe if health is not low
        }

        // Trigger the HPCheck event
        HPCheck?.Invoke(this, e);
    }

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
}
